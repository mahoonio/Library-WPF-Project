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
    /// Interaction logic for UserMemberShip.xaml
    /// </summary>
    public partial class UserMemberShip : Window
    {
        public Member member1;
        public UserMemberShip(Member member)
        {
            member1 = member;
            InitializeComponent();
            DataContext = member;
        }

        private void ExtendBtn_Click(object sender, RoutedEventArgs e)
        {
            if (member1.CashWallet >= 20000)
            {
                member1.CashWallet -= 20000;
                member1.SubscriptionTimeDay += 10;
                MessageBox.Show("your SubscriptionTimeDay updated for 10 weeks");
            }
            else
            {
                MessageBox.Show($"you need {20000 - member1.CashWallet} extra money ");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
