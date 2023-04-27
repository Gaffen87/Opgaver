using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreaTest
{
    public class Controller
    {
        OpskriftRepo Repo = new OpskriftRepo();

        public void AddOpskriftToList(string navn, Sprog sprog, Type type, Værdikode værdi)
        {
            Repo.AddOpskrift(Repo.OpretOpskrift(navn, sprog, type, værdi));
        }

        public void ShowList(string name = null,
            Sprog sprog = Sprog.Alle,
            Type type = Type.Alle,
            Værdikode værdi = Værdikode.Alle)
        {
            Repo.ShowList(name, sprog, type, værdi);
        }
    }
}
