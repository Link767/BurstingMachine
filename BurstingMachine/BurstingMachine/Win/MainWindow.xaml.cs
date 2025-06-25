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
using System.Drawing;
using ScottPlot;
using ScottPlot.WPF;
using System.Drawing.Printing;
using System.Xml.Linq;
using BurstingMachine.Pages;

namespace BurstingMachine
{
    public partial class MainWindow : Window
    {
        private SerialPort _serialPort = new SerialPort();
        public MainWindow()
        {
            InitializeComponent();
            LoadComPort();
            ChartFrame.Navigate(new Chart());

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
    }
}