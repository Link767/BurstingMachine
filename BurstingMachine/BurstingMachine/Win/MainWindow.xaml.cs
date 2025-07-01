using BurstingMachine.Lib;
using BurstingMachine.Pages;
using BurstingMachine.Win;
using Microsoft.Win32;
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
using static MaterialDesignThemes.Wpf.Theme;
using System.Diagnostics;
using System.IO;
using ScottPlot.Colormaps;

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
        private void History_Click(object sender, RoutedEventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
        }
        private void btnHelp_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            ChartFrame.Navigate(new Reports());
        }

        private void Chart_Click(object sender, RoutedEventArgs e)
        {
            ChartFrame.Navigate(new Chart());
            btnChart.BorderBrush = System.Windows.Media.Brushes.Green;
            btnChart.BorderThickness = new Thickness(10);

        }
    }
}