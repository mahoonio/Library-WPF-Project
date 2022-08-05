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
    /// Interaction logic for UserPannel.xaml
    /// </summary>
    public partial class UserP : Window
    {
        public Member member;
        UserWallet Uw;
        UserMemberShip userMemberShip;
        public UserP(Member member1)
        {
            MessageBox.Show($"hi dear{member1.UserName}");
            member = member1;
            InitializeComponent();
            DataContext = member;
        }

        private void WalletBtn_Click(object sender, RoutedEventArgs e)
        {
            Uw = new UserWallet(member);
            Uw.Show();
        }

        private void MShipBtn_Click(object sender, RoutedEventArgs e)
        {
            userMemberShip = new UserMemberShip(member);
            userMemberShip.Show();
        }

        private void EprofileBtn_Click(object sender, RoutedEventArgs e)
        {
            UEditProfile Ep = new UEditProfile(member);
            Ep.Show();
        }

        private void LbooksBtn_Click(object sender, RoutedEventArgs e)
        {
            UserLibraryBooks ULb = new UserLibraryBooks(member);
            ULb.Show();
        }

        private void Mboo_Click(object sender, RoutedEventArgs e)
        {
            UserMyBooks UMb = new UserMyBooks(member);
            UMb.Show();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
