using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
	public class Order
	{
		public BonusProvider Bonus;	// Erklærer en delegate kaldet Bonus								

		private List<Product> products = new List<Product>(); // Liste over produkter

		public void AddProduct(Product p) // tilføjer produkter til listen
		{
			products.Add(p);
		}

		public double GetValueOfProducts() // udregner den samlede værdi af alle produkter i listen
		{
			double value = 0;
			foreach (Product p in products)
			{
				value += p.Value;
			}
			return value;
		}

		public double GetBonus() // udregner bonus ud fra samlet værdi
		{
			return Bonus(GetValueOfProducts());
		}

		public double GetTotalPrice() // udregner pris ud fra samlet værdi minus bonus
		{ 
			return GetValueOfProducts() - GetBonus();
		}
    }
}
