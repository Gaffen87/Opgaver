using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreaTest
{
    public class OpskriftRepo
    {
        private List<Opskrift> opskriftsliste = new List<Opskrift>();

        public Opskrift OpretOpskrift(string navn, Sprog sprog, Type type, Værdikode værdi)
        {
            return new Opskrift(navn, sprog, type, værdi);
        }

        public void AddOpskrift(Opskrift opskrift)
        {
            opskriftsliste.Add(opskrift);
        }

        public void ShowList(string name, Sprog sprog, Type type, Værdikode værdi)
        {
            foreach (var item in opskriftsliste)
            {
                if (name == null)
                {
                    if ((sprog == Sprog.Alle || item.Sprog == sprog) && (item.Type == type || type == Type.Alle) && (item.Værdi == værdi || værdi == Værdikode.Alle))
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    if (item.Navn.Contains(name) && (sprog == Sprog.Alle || item.Sprog == sprog) && (item.Type == type || type == Type.Alle) && (item.Værdi == værdi || værdi == Værdikode.Alle))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
