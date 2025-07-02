using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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
using ScottPlot;
using ScottPlot.Plottables;
using ScottPlot.WPF;

namespace BurstingMachine.Pages
{
    public partial class Chart : Page
    {

        public Chart()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            double[] dataX = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] dataY = { 1, 4, 6, 8, 10, 12, 14, 16, 10 };
            var myPlot = WpfPlot1.Plot.Add.Scatter(dataX, dataY);
            myPlot.LineColor = ScottPlot.Colors.Red;
            myPlot.MarkerColor = ScottPlot.Colors.Red;
            WpfPlot1.Refresh();
        }

        private void btnNormalize_Click(object sender, RoutedEventArgs e)
        {
            WpfPlot1.Plot.Axes.AutoScale();
            WpfPlot1.Refresh();
        }

        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnReduce_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
