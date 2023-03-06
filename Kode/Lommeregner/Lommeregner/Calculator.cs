using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    public class Calculator
    {
        public int Add (int x, int y)
        {
            return x + y;
        }

        public int Subtract (int x, int y)
        {
            return x - y;
        }

        public double Divide (int x, int y)
        {
            double d = (double)x / (double)y;
            return d;
        }

        public int Multiply (int x, int y)
        {
            return x * y;
        }
    }
}
