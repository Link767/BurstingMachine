using System;
using System.Collections.Generic;
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
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };
            var myPlot = WpfPlot1.Plot.Add.Scatter(dataX, dataY);
            myPlot.LineColor = ScottPlot.Colors.Red;
            myPlot.MarkerColor = ScottPlot.Colors.Red;
            WpfPlot1.Refresh();
        }
    }
}
