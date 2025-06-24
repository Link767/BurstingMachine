using BurstingMachine.Lib;
using System.IO.Ports;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BurstingMachine
{
    public partial class MainWindow : Window
    {
        private SerialPort _serialPort = new SerialPort();
        public MainWindow()
        {
            InitializeComponent();
            LoadComPort();

        }
        private byte CalculateBCC(byte[] data)
        {
            byte bcc = 0;
            foreach (var b in data)
                bcc += b; // если в STM32 XOR, если сумма — просто bcc += b
            return bcc;
        }
        private void LoadComPort()
        {
            string[] ports = SerialPort.GetPortNames();
            CBPort.ItemsSource = ports;

            if (ports.Length > 0)
                CBPort.SelectedIndex = 0;
            else
                CBPort.Text = "Нет доступных COM портов";
        }
        private void SendCheckCommand()
        {
            var cmd = new ShortCommand
            {
                Head = new ProgHead20
                {
                    Marker = 0x14,
                    CmdType = DevCmdType.Check, // CMD_CHECK = 0
                    Length = 6
                },
                Num = 0,
                Bcc = 0 // временно
            };

            byte[] data = StructConverter.ToBytes(cmd);
            data[^1] = CalculateBCC(data[..^1]); // пересчёт BCC

            _serialPort.Write(data, 0, data.Length);

            // для отладки можно вывести лог
            Console.WriteLine("Check-команда отправлена: " + BitConverter.ToString(data));
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (CBPort.SelectedItem == null)
            {
                CBPort.Text = "Выберите COM порт";
                return;
            }

            try
            {
                string selectedPort = CBPort.SelectedItem.ToString();
                _serialPort.PortName = selectedPort;
                _serialPort.BaudRate = 9600;
                _serialPort.Parity = Parity.None;
                _serialPort.DataBits = 8;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Handshake = Handshake.None;
                _serialPort.Open();

                MessageBox.Show($"Подключено к {selectedPort}");

                // 👉 Отправляем команду CMD_CHECK
                SendCheckCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (!_serialPort.IsOpen)
            {
                MessageBox.Show("COM-порт не открыт");
                return;
            }

            // Сборка команды UP
            ShortCommand cmd = new ShortCommand
            {
                Head = new ProgHead20
                {
                    Marker = 0x14, // PRG_FLAG_20
                    CmdType = DevCmdType.GoToUp,
                    Length = 6     // длина команды
                },
                Num = 0,
                Bcc = 0 // потом обновим
            };

            // Получаем байты
            byte[] bytes = StructConverter.ToBytes(cmd);
            bytes[^1] = CalculateBCC(bytes[..^1]); // пересчитываем BCC

            // Отправка
            _serialPort.Write(bytes, 0, bytes.Length);

            MessageBox.Show("Команда UP отправлена");
        }
    }
}