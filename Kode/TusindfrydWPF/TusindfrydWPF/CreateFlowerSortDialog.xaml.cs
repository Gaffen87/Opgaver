using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TusindfrydWPF
{
	/// <summary>
	/// Interaction logic for CreateFlowerSortDialog.xaml
	/// </summary>
	public partial class CreateFlowerSortDialog : Window
	{
		public FlowerSort flowersort = new FlowerSort();

		public CreateFlowerSortDialog()
		{
			InitializeComponent();
		}

		private void btOkay_Click(object sender, RoutedEventArgs e)
		{
			flowersort.Name = tbNavn.Text;
			flowersort.PicturePath = tbBilledsti.Text;

			bool b = int.TryParse(tbProduktionstid.Text, out int prod);
			if (b)
			{
				flowersort.ProductionTime = prod;
			}

			bool c = int.TryParse(tbHalveringstid.Text, out int half);
			if (c)
			{
				flowersort.HalfLifeTime = half;
			}

			bool d = int.TryParse(tbStørrelse.Text, out int size);
			if (d)
			{
				flowersort.Size = size;
			}

			DialogResult = true;
		}

		private void btFortryd_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
		}

		private void tbTextChanged(object sender, TextChangedEventArgs e)
		{
			if (tbNavn.Text != "" && tbProduktionstid.Text != "" && tbHalveringstid.Text != "" && tbStørrelse.Text != "")
				btOkay.IsEnabled = true;
		}

		private void TbBilledsti_LostFocus(object sender, RoutedEventArgs e)
		{
			try
			{
				Uri sti = new Uri(tbBilledsti.Text);
				imgFlower.Source = new BitmapImage(sti);
			}
			catch
			{ 
			}
			finally
			{
				tbBilledsti.Clear();
			}
		}
	}
}
