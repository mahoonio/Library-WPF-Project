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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace LoginPageTest.MVM.View
{
    /// <summary>
    /// Interaction logic for LibraryBooksView.xaml
    /// </summary>
    /// 

    public partial class LibraryBooksView : UserControl
    {

        public ObservableCollection<Book> books { get; set; }


        public LibraryBooksView()
        {

            books = new ObservableCollection<Book>();
            for(int i = 0; i < Collections.BorrowedBooks.Count; i++)
            {
                books.Add(Collections.BorrowedBooks[i]);
            }

            InitializeComponent();
            DataContext = this;
            
        }
        //buttun's click
        private void SearchBooksBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AllBookBox_Click(object sender, RoutedEventArgs e)
        {
            //AllBooks
            books.Clear();
            for (int i = 0; i < Collections.AllBooks.Count; i++)
            {
                books.Add(Collections.AllBooks[i]);
            }
        }
        private void BorrowedBookBox_Click(object sender, RoutedEventArgs e)
        {
            //BorrowedBooks
            books.Clear();
            for (int i = 0; i < Collections.BorrowedBooks.Count; i++)
            {
                books.Add(Collections.BorrowedBooks[i]);
            }
        }
        private void AvailableBookBox_Click(object sender, RoutedEventArgs e)
        {
            //AvailableBook
            books.Clear();
            for (int i = 0; i < Collections.AvailableBooks.Count; i++)
            {
                books.Add(Collections.AvailableBooks[i]);
            }
        }
    }
}
