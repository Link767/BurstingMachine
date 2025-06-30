using BurstingMachine.Lib;
using BurstingMachine.Pages;
using BurstingMachine.Win;
using ScottPlot;
using ScottPlot.WPF;
using System.Diagnostics.Metrics;
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
        public MainWindow()
        {
            InitializeComponent();
            ChartFrame.Navigate(new Chart());
        }

        private void SetingsPage_Click(object sender, RoutedEventArgs e)
        {
            ChartFrame.Navigate(new Setings());
        }

        private void Chart_Click(object sender, RoutedEventArgs e)
        {
            ChartFrame.Navigate(new Chart());

        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
        }
        private void btnHelp_Click_1(object sender, RoutedEventArgs e)
        {
            MessageInf messageInf = new MessageInf("Тут будет подсказка");
            messageInf.Show();
        }

        private void CBMeasurement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CBMeasurement.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedText = selectedItem.Content.ToString();

                switch (selectedText)
                {
                    case "Однократное измерение":
                        btnLogs.Visibility = Visibility.Collapsed;
                        LineLogs.Visibility = Visibility.Collapsed;
                        break;
                    case "Множественное измерение":
                        btnLogs.Visibility = Visibility.Visible;
                        LineLogs.Visibility = Visibility.Visible;
                        break;
                }
            }
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            ChartFrame.Navigate(new Reports());
        }
    }
}