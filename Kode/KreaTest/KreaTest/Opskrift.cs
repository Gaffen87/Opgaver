using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreaTest
{
    public class Opskrift
    {
        public string Navn { get; set; }
        public Sprog Sprog { get; set; }
        public Type Type { get; set; }
        public Værdikode Værdi { get; set; }

        public Opskrift(string navn, Sprog sprog, Type type, Værdikode værdi)
        {
            Navn = navn;
            Sprog = sprog;
            Type = type;
            Værdi = værdi;
        }

        public override string ToString()
        {
            return $"Navn: {Navn}, Sprog: {Sprog}, Type: {Type}, Værdi: {(int)Værdi} kr";
        }
    }
}
