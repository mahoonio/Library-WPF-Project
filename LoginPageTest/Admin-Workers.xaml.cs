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
	/// Interaction logic for Admin_Workers.xaml
	/// </summary>

	public class Person
	{
		public string name { get; set; }
		public string LastName { get; set; }
		public Person(string a, string b)
		{
			name = a;
			LastName = b;
		}
	}
	public partial class Admin_Workers : Window
    {
		public ObservableCollection<Person> people { get; set; }

		public Admin_Workers()
		{
			people = new ObservableCollection<Person>();
			people.Add(new Person("narges", "masha"));
			people.Add(new Person("mahan", "mahmoodi"));
			people.Add(new Person("Ali", "Heydari"));
			InitializeComponent();
			cm.ItemsSource = people;
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
			for (int i = 0; i < people.Count; i++)
			{
				var k = (Person)cm.SelectedItem;
				if (k != null)
				{
					string l = k.name;
					Console.WriteLine(l);

					if (people[i].name.Equals(l)) ;
					{
						people.Remove(k);
						MessageBox.Show("worker is removed");
						return;
					}
				}
			}
		}
		

        private void AddWorkerBtn_Click(object sender, RoutedEventArgs e)
        {
            Admin_Workers_AddWorker AWorkerAdd = new Admin_Workers_AddWorker();
            AWorkerAdd.Show();
        }

        private void PayWorkersBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
