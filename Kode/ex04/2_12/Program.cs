using System.Data;

namespace _2_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indlæs regnestykke: ");
            string str = Console.ReadLine();

            if (str == null)
            {
                Console.WriteLine("Intet input. Lukker...");
                Console.ReadKey();
                return;
            }

            str = str.Replace(" ", "");

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] < 48 || str[i] > 57) && str[i] != 43 && str[i] != 45 && str[i] != 42 && str[i] != 47)
                {
                    Console.WriteLine("Forkert input. Lukker...");
                    Console.ReadKey();
                    return;
                }
            }

            var result = new DataTable().Compute(str, "");

            Console.WriteLine("Resultatet er: "+result);
            Console.ReadKey();
        }
    }
}