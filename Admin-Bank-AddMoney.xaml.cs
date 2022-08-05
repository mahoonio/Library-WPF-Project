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
    /// Interaction logic for Admin_Bank_AddMoney.xaml
    /// </summary>
    public partial class Admin_Bank_AddMoney : Window
    {
        public Admin_Bank_AddMoney()
        {
            InitializeComponent();
        }

        private void AddMoneyBtn_Click(object sender, RoutedEventArgs e)
        {
            // code e back end marboot be ezafe kardane pool
            if (methods.IsValidCartNumber(card1box.Text + card2box.Text + card3box.Text + card4box.Text)
            && methods.IsValidCVV(cvv2box.Text)
            && methods.IsValidYearAndMonth(yearbox.Text, monthbox.Text))
            {
                try
                {
                    Fields.LibMoneyBank += int.Parse(MoneyAmmount.Text);
                    MessageBox.Show("your payment was successful");
                }
                catch
                {
                    MessageBox.Show("payment faild , enter a correct value for price");
                }
            }
            else
            {
                MessageBox.Show("Wrong information");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
