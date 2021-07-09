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
        public List<Book> AllBooks { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public List<Book> AvailableBook { get; set; }

        public LibraryBooksView()
        {
            AllBooks = new List<Book>();
            BorrowedBooks = new List<Book>();
            AvailableBook = new List<Book>();
            books = new ObservableCollection<Book>();

            // inja be jaye in ke khodam meghdar bedam bayad maghadir az data base por shan
            AllBooks.Add(new Book { Name = "Borrowed1", Author = "writer1", EditonNumber = "e1" });
            AllBooks.Add(new Book { Name = "Borrowed2", Author = "writer2", EditonNumber = "e2" });
            AllBooks.Add(new Book { Name = "Borrowed3", Author = "writer3", EditonNumber = "e3" });
            AllBooks.Add(new Book { Name = "Available1", Author = "writer4", EditonNumber = "e4" });
            AllBooks.Add(new Book { Name = "Available2", Author = "writer5", EditonNumber = "e5" });

            BorrowedBooks.Add(new Book { Name = "Borrowed1", Author = "writer1", EditonNumber = "e1" });
            BorrowedBooks.Add(new Book { Name = "Borrowed2", Author = "writer2", EditonNumber = "e2" });
            BorrowedBooks.Add(new Book { Name = "Borrowed3", Author = "writer3", EditonNumber = "e3" });

            AvailableBook.Add(new Book { Name = "Available1", Author = "writer4", EditonNumber = "e4" });
            AvailableBook.Add(new Book { Name = "Available2", Author = "writer5", EditonNumber = "e5" });

            books.Add(new Book { Name = "Borrowed1", Author = "writer1", EditonNumber = "e1" });
            books.Add(new Book { Name = "Borrowed2", Author = "writer2", EditonNumber = "e2" });
            books.Add(new Book { Name = "Borrowed3", Author = "writer3", EditonNumber = "e3" });


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
            for (int i = 0; i < AllBooks.Count; i++)
            {
                books.Add(AllBooks[i]);
            }
        }
        private void BorrowedBookBox_Click(object sender, RoutedEventArgs e)
        {
            //BorrowedBooks
            books.Clear();
            for (int i = 0; i < BorrowedBooks.Count; i++)
            {
                books.Add(BorrowedBooks[i]);
            }
        }
        private void AvailableBookBox_Click(object sender, RoutedEventArgs e)
        {
            //AvailableBook
            books.Clear();
            for (int i = 0; i < AvailableBook.Count; i++)
            {
                books.Add(AvailableBook[i]);
            }
        }
    }
}
