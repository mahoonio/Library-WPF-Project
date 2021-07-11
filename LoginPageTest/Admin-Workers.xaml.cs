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

	}
	public partial class Admin_Workers : Window
    {


		public Admin_Workers()
		{
			InitializeComponent();
			cm.ItemsSource = Collections.Workers;
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
			for (int i = 0; i < Collections.Workers.Count; i++)
			{
				var k = (Worker)cm.SelectedItem;
				if (k != null)
				{
					string l = k.UserName;
					if (Collections.Workers[i].UserName.Equals(l))
					{
						Collections.Workers.Remove(k);
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
			MessageBoxResult result = MessageBox.Show("Would you like to confirm the password of this Payment operation? ", "Confirm Payment", MessageBoxButton.YesNoCancel);
			switch (result)
			{
				case MessageBoxResult.Yes:
					if (Fields.LibMoneyBank > Collections.Workers.Count*100000)//100000= the money each worker will earn per month
					{
						//inja bayad meghdare niyaz baraye hoghoogh karmanda faghat check she va bad ham az hesab kam she vali man nemidoonestam cheghade:))))
						MessageBox.Show("Payment Operation was successfull", "Confirm Payment");
					}
					else MessageBox.Show("there is no enough money");
					break;
				case MessageBoxResult.No:
					MessageBox.Show("Payment Operation was Faild", "Confirm Payment");
					break;
				case MessageBoxResult.Cancel:
					MessageBox.Show("Payment Operation was cancled", "Confirm Payment");
					break;
			}
		}

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
