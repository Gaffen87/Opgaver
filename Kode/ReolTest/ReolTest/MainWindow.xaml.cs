using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace ReolTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ObservableCollection<DateTime> dates = new();
		Controller ctrl = new();

		public MainWindow()
		{
			InitializeComponent();
			DataContext = ctrl;
		}

		private void cld_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
		{
			dates = cld.SelectedDates;
			startDato.Text = dates.First().ToShortDateString();
			slutDato.Text = dates.Last().ToShortDateString();

			ctrl.startDate = dates.First().ToString("yyyy-MM-dd");
			ctrl.endDate = dates.Last().ToString("yyyy-MM-dd");

			ctrl.ShowAvailable(dates.First().ToString("yyyy-MM-dd"), dates.Last().ToString("yyyy-MM-dd"));
		}

		private void cld_loaded(object sender, RoutedEventArgs e)
		{
			cld.BlackoutDates.AddDatesInPast();
		}
	}
}
