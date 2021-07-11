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
            foreach(Book book in Collections.AllBooks)
            {
                if (book.Name.Equals(BookNameBox.Text) && book.Author.Equals(AuthorBox.Text) && book.EditonNumber.Equals(EditonNumberBox.Text))
                {
                    book.Numbers++;
                    book.AvailableNumbers++;
                    MessageBox.Show("the numbers of book increaseed");
                    foreach(Book book2 in Collections.AllBooks)
                    {
                        if(book2.Name.Equals(BookNameBox.Text) && book2.Author.Equals(AuthorBox.Text) && book2.EditonNumber.Equals(EditonNumberBox.Text))
                        {
                            //avaeilable boode va hanooz ham hast
                        }
                        else
                        {
                            Collections.AvailableBooks.Add(book2);//availabe naboode va ba ezafe shodan be tedadesh alan yekish available hast
                        }
                    }
                    return;
                }
            }
            // dar constructor neveshtam ke vaghti sakhte mishe darja be allbook va availablebook ham add beshe
            Book book1 = new Book(BookNameBox.Text, AuthorBox.Text, EditonNumberBox.Text);
            MessageBox.Show("book added");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
