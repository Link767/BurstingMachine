using BurstingMachine.Classes;
using System.Windows;
using System.Windows.Controls;

namespace BurstingMachine.Pages
{
    public partial class Chart : Page
    {
        public static int PointNum; 
        public Chart()
        {
            InitializeComponent();
        }
        private async void LoadNewtonsAndSpeed()
        {
            for (double i = 0; i < 10; i += 0.10) 
            {
                if(PointNum == 0)
                {
                    TBNewtons.Text = i.ToString($"F2");
                    TBSpeed.Text = i.ToString($"F2");
                }
                else
                {
                    TBNewtons.Text = i.ToString($"F{PointNum}");
                    TBSpeed.Text = i.ToString($"F{PointNum}");
                }
                await Task.Delay(500); // 1 секунда паузы
            }
        }
        private async void LoadPlot()
        {
            List<double> dataX = new();
            List<double> dataY = new();

            double[] FulldataX = { 1, 2, 3, 4, 5, 6, 7, 8, 9}; //Чтобы работало колличество точек должно быть равным 
            double[] FulldataY = { 1, 4, 6, 8, 10, 12, 14, 16, 10}; //Чтобы работало колличество точек должно быть равным 

            var myPlot = WpfPlot1.Plot.Add.Scatter(dataX, dataY);
            myPlot.LineColor = ScottPlot.Colors.Red;
            myPlot.MarkerColor = ScottPlot.Colors.Red;

            WpfPlot1.Refresh();

            for (int i = 0; i < FulldataX.Length; i++)
            {
                dataX.Add(FulldataX[i]);
                dataY.Add(FulldataY[i]);

                AScale();
                await Task.Delay(500);
                if(FulldataX[i] ==FulldataX.Length)
                    MBClass.Inf("Измерение завершено");
            }
        }
        private void AScale()
        {
            WpfPlot1.Plot.Axes.AutoScale();
            WpfPlot1.Refresh();
        }
        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            LoadPlot();
            LoadNewtonsAndSpeed();
        }
        private void btnNormalize_Click(object sender, RoutedEventArgs e)
        {
            AScale();
        }
        /*1.0 = без изменения,
        < 1 = приближение,
        > 1 = отдаление.*/
        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
            WpfPlot1.Plot.Axes.Zoom(1.1); //Приближает на 10%
            WpfPlot1.Refresh();
        }
        private void btnReduce_Click(object sender, RoutedEventArgs e)
        {
            WpfPlot1.Plot.Axes.Zoom(0.9); //Отдаляет на 10%
            WpfPlot1.Refresh();
        }
    }
}
