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
using System.Collections.ObjectModel;

namespace LoginPageTest
{
    /// <summary>
    /// Interaction logic for UserLibraryBooks.xaml
    /// </summary>
    public partial class UserLibraryBooks : Window
    {
        public Member member1;
        public ObservableCollection<Book> books;
        public ObservableCollection<Book> l;
        public UserLibraryBooks(Member member)
        {
            member1 = member;
            l = new ObservableCollection<Book>();
            books = new ObservableCollection<Book>();
            for (int i = 0; i < Collections.AvailableBooks.Count; i++)
            {
                books.Add(Collections.AvailableBooks[i]);
            }
            InitializeComponent();
            bookList.ItemsSource = books;
        }


        private void amanatbox_Click(object sender, RoutedEventArgs e)
        {
            if (member1.SubscriptionTimeDay >= 1 && member1.NumbersOfBook < 5 && !member1.LateReturn)
            {
                try
                {
                    var x = (Book)bookList.SelectedItem;
                    string n = x.Name;
                    books.Remove(x);
                    l.Add(x);
                    member1.MyBooks.Add(x);
                    Collections.BorrowedBooks.Add(x);
                    MessageBox.Show($"book with name {n}  and Author {x.Author}  added to your books");
                    Collections.AvailableBooks.Clear();
                    for (int i=0;i < books.Count; i++)
                    {
                        Collections.AvailableBooks.Add(books[i]);
                    }
                }
                catch
                {
                    MessageBox.Show("please select one of the ithem");
                }
                return;
            }
            else
            {
                MessageBox.Show("you can't borrow any more book");
            }

        }


        private void searchbutton_Click(object sender, RoutedEventArgs e)
        {
            //wrong cases
            if (BookName.IsChecked == true && AuthorName.IsChecked == true)
            {
                MessageBox.Show("please just choose one option for search"); return;
            }

            if (BookName.IsChecked == false && AuthorName.IsChecked == false)
            {
                MessageBox.Show("please choose one of the option for search");
                return;
            }

            if (searchbox.Text.Equals(""))
            {
                MessageBox.Show("please fill out the searchbox");
                return;
            }


            //searching by BookName
            if (BookName.IsChecked == true && AuthorName.IsChecked == false && !searchbox.Text.Equals(""))
            {
                books.Clear();
                foreach (Book book in Collections.AvailableBooks)
                {
                    if (book.Name.Equals(searchbox.Text))
                    {
                        books.Add(book);
                    }
                }
                return;
            }

            //searching by AuthorName
            if (BookName.IsChecked == false && AuthorName.IsChecked == true && !searchbox.Text.Equals(""))
            {
                books.Clear();
                foreach (Book book in Collections.AvailableBooks)
                {
                    if (book.Author.Equals(searchbox.Text))
                    {
                        books.Add(book);
                    }
                }
            }
            return;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}


