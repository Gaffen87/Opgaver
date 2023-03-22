using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId) 
        {
            foreach (var amulet in amulets)
            {
                if (amulet.ItemId == itemId)
                    return amulet;
            }
            return null;
        }

        //public double GetTotalValue()
        //{
        //    double total = 0;
        //    Utility utility = new Utility();
        //    foreach (var amulet in amulets)
        //    {
        //        total += utility.GetValueOfAmulet(amulet);
        //    }
        //    return total;
        //}

    }
}
