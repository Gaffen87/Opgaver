using Microsoft.Data.SqlClient;
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
using System.Configuration;
using System.Diagnostics;
using System.Data;

namespace TusindfrydWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		//List<FlowerSort> sorts;
		private string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseServerInstance"].ConnectionString;

		public MainWindow()
		{
			InitializeComponent();
			//sorts = new List<FlowerSort>();
			//Update();
			//Delete();
			RetrieveAll();
		}

		private void btOpret_Click(object sender, RoutedEventArgs e)
		{
			CreateFlowerSortDialog create = new CreateFlowerSortDialog();
			if (create.ShowDialog() == true)
			{
				//sorts.Add(create.flowersort);
				tbBlomsterListe.Clear();
				RetrieveAll();
			}
		}

		void RetrieveAll()
		{
			string QueryString = "SELECT * FROM FlowerSort";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand(QueryString, connection);
				using (SqlDataReader reader = cmd.ExecuteReader()) 
				{
					while (reader.Read())
					{
						FlowerSort flower = new FlowerSort();
						{
							flower.Name = reader["Name"].ToString();
							flower.ProductionTime = int.Parse(reader["ProductionTimeInDays"].ToString());
							flower.HalfLifeTime = int.Parse(reader["HalfLife"].ToString());
							flower.Size = int.Parse(reader["Size"].ToString());
							flower.PicturePath = reader["ImagePath"].ToString();
						}
						//sorts.Add(flower);
						if (tbBlomsterListe.Text == "")
							tbBlomsterListe.Text = flower.Name;
						else
							tbBlomsterListe.AppendText("\n" + flower.Name);

						Debug.WriteLine(flower.ToString());
					}
				}
			}
		}

		void Update()
		{
			string NewName = "Bellis";
			string Name = "Rose";
			string QueryString = $"UPDATE FlowerSort SET Name = '{NewName}' Where Name = '{Name}'";

			//string QueryString = $"UPDATE FlowerSort SET Name = @NewName Where Name = @Name";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand(QueryString, connection);
				//cmd.Parameters.Add("@NewName", SqlDbType.NVarChar).Value = "Bellis";
				//cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = "Rose";
				cmd.ExecuteNonQuery();
			}
		}

		void Delete()
		{
			string QueryString = "DELETE FROM FlowerSort";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand(QueryString, connection);
				cmd.ExecuteNonQuery();
			}
		}
	}
}
