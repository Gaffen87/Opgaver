using System.Collections;
using System.ComponentModel;

namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            
            while(true)
            {
                Console.WriteLine("Calculator");
                Console.WriteLine("1. Add\n2. Subtract\n3. Divide\n4. Multiply");
                Console.WriteLine("Vælg funktion: ");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.Write("First number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Second number: ");
                int y = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        int sum = calc.Add(x, y);
                        Console.WriteLine("\n{0} + {1} = {2}", x, y, sum);
                        Console.ReadKey();
                        break;
                    case 2:
                        sum = calc.Subtract(x, y);
                        Console.WriteLine("\n{0} - {1} = {2}", x, y, sum);
                        Console.ReadKey();
                        break;
                    case 3:
                        double sumD = calc.Divide(x, y);
                        Console.WriteLine("\n{0} / {1} = {2:0.00}", x, y, sumD);
                        Console.ReadKey();
                        break;
                    case 4:
                        sum = calc.Multiply(x, y);
                        Console.WriteLine("\n{0} * {1} = {2}", x, y, sum);
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }
    }
}