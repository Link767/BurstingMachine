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
using System.Windows.Shapes;

namespace BurstingMachine.Win
{
    public partial class MessageErr : Window
    {
        public MessageErr(string mess)
        {
            InitializeComponent();
            TBlockError.Text = mess;
        }

        private void TBOk_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
