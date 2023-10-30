using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }

        public double GetValueOfProducts()
        {
            //double valueOfProducts = 0;
            //foreach (Product product in _products)
            //{
            //    valueOfProducts += product.Value;
            //}
            //return valueOfProducts;

            return _products.Sum(s => s.Value);
        }

        public double GetValueOfProducts(DateTime date)
        {
            //return _products.Where(s => s.AvailableFrom <= date && s.AvailableTo >= date).Sum(s => s.Value);
            return _products.Sum(s => s.AvailableFrom <= date && s.AvailableTo >= date ? s.Value : 0);
        }

        public List<Product> SortProductOrderByAvailableTo()
        {
            return _products.OrderBy(s => s.AvailableTo).ToList();
        }

		public List<Product> SortProductOrderBy(Func<Product, object> keySelector)
        {
            return _products.OrderBy(s => keySelector(s)).ToList();
        }

		public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetBonus(Func<double, double> provider)
        {
           return provider(GetValueOfProducts());
        }

        public double GetBonus(DateTime date, Func<double, double> provider)
        {
            return provider(GetValueOfProducts(date));
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }

        public double GetTotalPrice(Func<double, double> provider)
        {
            return GetValueOfProducts() - GetBonus(provider);
        }

        public double GetTotalPrice(DateTime date, Func<double, double> provider)
        {
            return (GetValueOfProducts(date) - GetBonus(date, provider));
        }
    }
}
