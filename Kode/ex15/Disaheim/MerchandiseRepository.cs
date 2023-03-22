using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise> { };

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId) 
        {
            foreach (var item in merchandises)
            {
                if (item.ItemId == itemId)
                {
                    return item;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            Utility utility = new Utility();

            foreach(var item in merchandises)
            {
                totalValue += utility.GetValueOfMerchandise(item);
            }
            return totalValue;
        }

    }
}
