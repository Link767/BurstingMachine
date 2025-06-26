using BurstingMachine.Lib;
using BurstingMachine.Pages;
using BurstingMachine.Win;
using ScottPlot;
using ScottPlot.WPF;
using System.Drawing;
using System.Drawing.Printing;
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
using System.Xml.Linq;

namespace BurstingMachine
{
    public partial class MainWindow : Window
    {
        private SerialPort _serialPort = new SerialPort();
        public MainWindow()
        {
            InitializeComponent();
            ChartFrame.Navigate(new Chart());
        }
        private byte CalculateBCC(byte[] data)
        {
            byte bcc = 0;
            foreach (var b in data)
                bcc += b; // если в STM32 XOR, если сумма — просто bcc += b
            return bcc;
        }
        private void SetingsPage_Click(object sender, RoutedEventArgs e)
        {
            ChartFrame.Navigate(new Setings());
        }

        private void Err_Click(object sender, RoutedEventArgs e)
        {
            string i = "Test";
            MessageErr messageErr = new MessageErr(i);
            messageErr.Show();
        }
    }
}