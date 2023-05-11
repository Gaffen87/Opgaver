using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CommandBindListBox.Model
{
	public class ProductRepo
	{
		List<Product> products = new List<Product>()
		{
			new Product()
			{
				Name = "Apple", Price = 7.96
			},
			new Product()
			{
				Name = "Orange", Price = 5.50
			},
			new Product()
			{
				Name = "Banana", Price = 8.25
			}
		};

		public List<Product> GetAll()
		{
			return products;
		}

		public void Add(Product product)
		{
			products.Add(product);
		}

		public void Remove(Product product)
		{
			products.Remove(product);
		}
	}
}
