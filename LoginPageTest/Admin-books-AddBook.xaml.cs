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
    /// Interaction logic for Admin_books_AddBook.xaml
    /// </summary>
    public partial class Admin_books_AddBook : Window
    {
        public Admin_books_AddBook()
        {
            InitializeComponent();
        }

        private void AddBtnAB_Click(object sender, RoutedEventArgs e)
        {
            //code e backend e add kardane ketab
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
