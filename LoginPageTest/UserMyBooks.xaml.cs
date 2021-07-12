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
    /// Interaction logic for UserMyBooks.xaml
    /// </summary>
    public partial class UserMyBooks : Window
    {
        public Member Member1;
        public ObservableCollection<Book> Mybook { get; set; }
        public UserMyBooks(Member member)
        {
            Member1 = member;
            InitializeComponent();
            DataContext = this;
            Mybook = new ObservableCollection<Book>(Member1.MyBooks);
        }
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (cm.SelectedIndex > 0)
                cm.SelectedIndex = cm.SelectedIndex - 1;
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (cm.SelectedIndex < cm.Items.Count - 1)
                cm.SelectedIndex = cm.SelectedIndex + 1;
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            var book = (Book)cm.SelectedItem;
            book.AvailableNumbers++; book.BorrowedNumbers--;
            Member1.NumbersOfBook--;
            Member1.MyBooks.Remove(book);
            Collections.AvailableBooks.Add(book);
            if (book.AvailableNumbers == 1)
            {
                Collections.AvailableBooks.Add(book);
            }
            if (book.BorrowedNumbers == 0)
            {
                Collections.BorrowedBooks.Remove(book);
            }
            Member1.MyBooks.Remove(book);
            MessageBox.Show($"{book.Name} removed from your list");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
