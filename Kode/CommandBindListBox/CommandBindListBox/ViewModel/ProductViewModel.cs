using CommandBindListBox.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandBindListBox.ViewModel
{
	public class ProductViewModel
	{
		private Product product;

        public string Name { get; set; }
        public double Price { get; set; }

		public ProductViewModel(Product product)
		{
			this.product = product;
			this.Name = product.Name;
			this.Price = product.Price;
		}

		public void Remove(ProductRepo repo)
		{
			repo.Remove(product);
		}
    }
}
