using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Collections.ObjectModel;

namespace ReolTest
{
	public class Controller
	{
        string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        private ObservableCollection<Reol> reoler = new ObservableCollection<Reol>();
        public ObservableCollection<Reol>? Reoler
        { 
            get { return reoler; } 
        }

        public Controller()
        {
            ShowAvailable("2000-01-01", "2100-01-01");
        }

        public string? startDate { get; set; }
        public string? endDate { get; set; }

        public void ShowAvailable(string startDate, string endDate)
        {
            reoler.Clear();

            string qString1 = "SELECT * FROM Stand WHERE standID NOT IN";
            string qString2 = "(SELECT standID FROM StandRentalPeriod WHERE rentalID IN";
            string qString3 = $"(SELECT rentalID FROM RentalPeriod WHERE '{startDate}' BETWEEN startDate AND endDate OR";
            string qString4 = $"'{endDate}' BETWEEN startDate AND endDate))";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new(qString1 + qString2 + qString3 + qString4, con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reol reol = new Reol
                        {
                            ReolID = int.Parse(reader["standID"].ToString()),
                            Type = reader["Type"].ToString()
                        };
                        reoler.Add(reol);
                    }
                }
            }
        }
    }
}
