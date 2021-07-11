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

namespace LoginPageTest
{
    /// <summary>
    /// Interaction logic for UserWalletAddMoney.xaml
    /// </summary>
    public partial class UserWalletAddMoney : Window
    {
        public UserWalletAddMoney()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddMoneyBtn_Click(object sender, RoutedEventArgs e)
        {
            UserWalletAddMoney UwA = new UserWalletAddMoney();
            UwA.Show();
        }
    }
}
