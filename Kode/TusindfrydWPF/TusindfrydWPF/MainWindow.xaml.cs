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

namespace TusindfrydWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<FlowerSort> sorts;

		public MainWindow()
		{
			InitializeComponent();
			sorts = new List<FlowerSort>();
		}

		private void btOpret_Click(object sender, RoutedEventArgs e)
		{
			CreateFlowerSortDialog create = new CreateFlowerSortDialog();
			if (create.ShowDialog() == true)
			{
				sorts.Add(create.flowersort);
				if (tbBlomsterListe.Text == "")
					tbBlomsterListe.Text = create.flowersort.Name;
				else
					tbBlomsterListe.AppendText("\n" +  create.flowersort.Name);
			}
		}
	}
}
