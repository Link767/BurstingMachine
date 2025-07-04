using BurstingMachine.Classes;
using BurstingMachine.Win;
using System.Windows.Controls;

namespace BurstingMachine.Pages
{
    public partial class Reports : Page
    {
        public Reports()
        {
            InitializeComponent();
            LoadStaff();
        }
        private void LoadStaff()
        {
            Users user = new Users();
            user.Name = Environment.UserName;
            user.Mash = Environment.MachineName;
            string dt = DateTime.Now.ToString();
            TBNameStaff.Text = user.Name;
        }

        private void btnPushMail_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if((string.IsNullOrEmpty(TBNameStaff.Text)) || (string.IsNullOrEmpty(TBNameTest.Text)))
            {
                MBClass.Err("Пожалуйста заполните все обезательные пополя");
            }
            else
            {
                PushMail pushMail = new PushMail();
                pushMail.Show();
                return;
            }
        }
    }
}
