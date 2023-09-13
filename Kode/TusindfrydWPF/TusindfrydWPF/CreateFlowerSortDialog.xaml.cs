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
using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Diagnostics;

namespace TusindfrydWPF
{
	/// <summary>
	/// Interaction logic for CreateFlowerSortDialog.xaml
	/// </summary>
	public partial class CreateFlowerSortDialog : Window
	{
		public FlowerSort flowersort = new FlowerSort();
		private string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseServerInstance"].ConnectionString;

		public CreateFlowerSortDialog()
		{
			InitializeComponent();
		}

		private void Create(FlowerSort flowerSort)
		{
			string QueryString = "INSERT INTO FlowerSort (Name, ProductionTimeInDays, HalfLife, Size, ImagePath)" + "VALUES(@Name, @ProductionTimeInDays, @HalfLife, @Size, @ImagePath)" + "SELECT @@IDENTITY";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				SqlCommand cmd = new SqlCommand(QueryString, connection);
				cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = flowersort.Name;
				cmd.Parameters.Add("@ProductionTimeInDays", SqlDbType.Int).Value = flowersort.ProductionTime;
				cmd.Parameters.Add("@HalfLife", SqlDbType.Int).Value = flowersort.HalfLifeTime;
				cmd.Parameters.Add("@Size", SqlDbType.Float).Value = (float)flowersort.Size;
				cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = flowersort.PicturePath;
				try
				{
					connection.Open();
					int rows = cmd.ExecuteNonQuery();
					Debug.WriteLine($"{rows} affected");
				}
				catch (SqlException ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally
				{ 
					connection.Close();
                }
			}
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

			Create(flowersort);

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
				//tbBilledsti.Clear();
			}
		}
	}
}
