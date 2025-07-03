using BurstingMachine.Pages;
using BurstingMachine.Win;
using System.Windows;
using System.Diagnostics;
using System.IO;


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

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            ChartFrame.Navigate(new Reports());
            //OK
        }

        private void Chart_Click(object sender, RoutedEventArgs e)
        {
            ChartFrame.Navigate(new Chart());
            btnChart.BorderBrush = System.Windows.Media.Brushes.Green;
            btnChart.BorderThickness = new Thickness(10);

        }

        private void MIHelp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string relativePath = System.IO.Path.Combine("Doc", "Руководство.docx");
                string fullPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

                if (File.Exists(fullPath))
                {
                    Process.Start(new ProcessStartInfo(fullPath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Файл не найден:\n" + fullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла:\n" + ex.Message);
            }
        }

        private void MIControlRebut_Click(object sender, RoutedEventArgs e)//Перезапуск контроллера
        {

        }

        private void MIHistory_Click(object sender, RoutedEventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
        }
    }
}