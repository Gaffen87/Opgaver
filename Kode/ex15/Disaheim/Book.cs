using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Book(string itemId, string title, double price)
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Price = price;
        }
        public Book(string itemId, string title) : this(itemId, title, 0) { }
        public Book(string itemId) : this(itemId, "", 0) { }

        public override string ToString()
        { 
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
