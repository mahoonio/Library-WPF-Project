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
    /// Interaction logic for UserWallet.xaml
    /// </summary>
    public partial class UserWallet : Window
    {
        public UserWalletAddMoney userWalletAddMoney;

        public Member member1;
        public UserWallet(Member member)
        {
            member1 = member;
            InitializeComponent();
            DataContext = member;
        }

        private void AddMoneyBtn_Click(object sender, RoutedEventArgs e)
        {
            userWalletAddMoney = new UserWalletAddMoney(member1);
            userWalletAddMoney.Show();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
