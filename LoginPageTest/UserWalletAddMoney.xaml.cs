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
        public Member member1;
        public UserWalletAddMoney(Member member)
        {
            member1 = member;
            InitializeComponent();
            DataContext = member;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddMoneyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (methods.IsValidCartNumber(card1box.Text + card2box.Text + card3box.Text + card4box.Text)
                && methods.IsValidCVV(cvv2box.Text)
                && methods.IsValidYearAndMonth(yearbox.Text, monthbox.Text))
            try
            {

                member1.CashWallet += int.Parse(MoneyAmmount.Text);
            }
            catch
            {
                MessageBox.Show("wrong value for money!");
            }
            
            
        }
    }
}
