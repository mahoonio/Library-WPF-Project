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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PaymentBtn_Click(object sender, RoutedEventArgs e)
        {
            if (methods.IsValidCartNumber(card1box.Text + card2box.Text + card3box.Text + card4box.Text)
                && methods.IsValidCVV(cvv2box.Text)
                && methods.IsValidYearAndMonth(yearbox.Text, monthbox.Text))
            {
                MessageBox.Show("your payment was successful");
            }
            else
            {
                MessageBox.Show("Wrong information");
            }
        }

        private void card3box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
