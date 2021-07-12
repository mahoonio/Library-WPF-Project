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
    /// Interaction logic for Admin_Bank.xaml
    /// </summary>
    public partial class Admin_Bank : Window
    {
        public static double MoneyBankAmount { get; set; }
        public Admin_Bank()
        {
            InitializeComponent();
            MoneyBankAmount = Fields.LibMoneyBank;
            DataContext = this;
        }

        private void AdminBankPay_Click(object sender, RoutedEventArgs e)
        {
            Admin_Bank_AddMoney ABanKMoney = new Admin_Bank_AddMoney();
            ABanKMoney.Show();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
