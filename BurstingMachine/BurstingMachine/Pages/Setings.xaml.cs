using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;

namespace BurstingMachine.Pages
{
    public partial class Setings : Page
    {
        public Setings()
        {
            InitializeComponent();
            LoadComPort();
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

        private void btnSetSetings_Click(object sender, RoutedEventArgs e)
        {
            Chart.PointNum = Convert.ToInt32(TBNumOrPoint.Text); // <----- Колличество точек после запятой

        }

        private void btnTestSetings_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
