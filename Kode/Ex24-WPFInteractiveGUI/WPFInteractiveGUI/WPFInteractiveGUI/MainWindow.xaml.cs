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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
		}

		private void NewPerson_Click(object sender, RoutedEventArgs e)
		{
			lbIndex.Content = $"Index {controller.PersonIndex}";
			lbPersonCount.Content = $"Person Count {controller.PersonCount}";

			controller.AddPerson();
			tbFirstName.Clear();
			tbLastName.Clear();
			tbAge.Clear();
			tbTelephoneNo.Clear();

			btDeletePerson.IsEnabled = true;
			btDown.IsEnabled = true;
			btUp.IsEnabled = true;
			tbFirstName.IsEnabled = true;
			tbLastName.IsEnabled = true;
			tbAge.IsEnabled = true;
			tbTelephoneNo.IsEnabled = true;
		}

		private void tbFirstName_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (controller.CurrentPerson != null)
			{
				controller.CurrentPerson.FirstName = tbFirstName.Text;
			}
		}

		private void tbLastName_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (controller.CurrentPerson != null)
			{
				controller.CurrentPerson.LastName = tbLastName.Text;
			}
		}

		private void tbAge_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (controller.CurrentPerson != null)
			{
				bool b = int.TryParse(tbAge.Text, out int age);
				if (b)
					controller.CurrentPerson.Age = age;
			}
		}

		private void tbTelephoneNo_TextChanged(object sender, TextChangedEventArgs e)
		{	
			if (controller.CurrentPerson != null)
			{
				controller.CurrentPerson.TelephoneNo = tbTelephoneNo.Text;
			}
		}

		private void btUp_Click(object sender, RoutedEventArgs e)
		{
			controller.NextPerson();
			lbIndex.Content = $"Index {controller.PersonIndex}";

			tbFirstName.Text = controller.CurrentPerson.FirstName;
			tbLastName .Text = controller.CurrentPerson.LastName;
			tbAge.Text = Convert.ToString(controller.CurrentPerson.Age);
			tbTelephoneNo.Text = controller.CurrentPerson.TelephoneNo;
		}

		private void btDown_Click(object sender, RoutedEventArgs e)
		{
			controller.PrevPerson();
			lbIndex.Content = $"Index {controller.PersonIndex}";

			tbFirstName.Text = controller.CurrentPerson.FirstName;
			tbLastName.Text = controller.CurrentPerson.LastName;
			tbAge.Text = Convert.ToString(controller.CurrentPerson.Age);
			tbTelephoneNo.Text = controller.CurrentPerson.TelephoneNo;
		}

		private void btDeletePerson_Click(object sender, RoutedEventArgs e)
		{
			controller.DeletePerson();
			lbPersonCount.Content = $"Person Count {controller.PersonCount}";
			lbIndex.Content = $"Index {controller.PersonIndex}";

			if (controller.PersonCount == 0)
			{
				tbFirstName.Clear();
				tbLastName.Clear();
				tbAge.Clear();
				tbTelephoneNo.Clear();

				btDeletePerson.IsEnabled = false;
				btDown.IsEnabled = false;
				btUp.IsEnabled = false;
				tbFirstName.IsEnabled = false;
				tbLastName.IsEnabled = false;
				tbAge.IsEnabled = false;
				tbTelephoneNo.IsEnabled = false;
			}
			else
			{
				tbFirstName.Text = controller.CurrentPerson.FirstName;
				tbLastName.Text = controller.CurrentPerson.LastName;
				tbAge.Text = Convert.ToString(controller.CurrentPerson.Age);
				tbTelephoneNo.Text = controller.CurrentPerson.TelephoneNo;
			}
		}
	}
}
