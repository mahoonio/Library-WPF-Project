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
    /// Interaction logic for Admin_Books.xaml
    /// </summary>
    public partial class Admin_Books : Window
    {
        public Admin_Books()
        {
            InitializeComponent();
			searchbook.ItemsSource = Collections.AllBooks;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(searchbook.ItemsSource);
			view.Filter = UserFilter;
		}
		private bool UserFilter(object item)
		{
			if (String.IsNullOrEmpty(txtFilter.Text))
				return true;
			else
				return ((item as Book).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
		}

		private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			CollectionViewSource.GetDefaultView(searchbook.ItemsSource).Refresh();
		}

		private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            Admin_books_AddBook Abookadd = new Admin_books_AddBook();
            Abookadd.Show();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
