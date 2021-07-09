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
    /// Interaction logic for AdminPannel.xaml
    /// </summary>
    public partial class AdminPannel : Window
    {
        public AdminPannel()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void WorkersBtn_Click(object sender, RoutedEventArgs e)
        {
            Admin_Workers Aworker = new Admin_Workers();
            Aworker.Show();
            
        }

        private void BooksBtn_Click(object sender, RoutedEventArgs e)
        {
            Admin_Books Abooks = new Admin_Books();
            Abooks.Show();
        }

        private void BankBtn_Click(object sender, RoutedEventArgs e)
        {
            Admin_Bank Abank = new Admin_Bank();
            Abank.Show();
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
