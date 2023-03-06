using System.Reflection.Metadata.Ecma335;

namespace ex06_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antal;
            double sum = 0;

            Console.WriteLine("Hvor mange personer? ");
            while (true)
            {                            
                bool succes = int.TryParse(Console.ReadLine(), out antal);
                if (!succes)
                {
                    Console.Clear();
                    Console.WriteLine("Forkert input!\n");
                    Console.WriteLine("Hvor mange personer? ");
                }
                else
                {
                    Console.Clear();
                    break;
                }                    
            }
           

            int[] age = new int[antal];

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv alder på person {0}", i+1);
                age[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine("Person {0} alder: {1}", i+1, age[i]);
                sum += age[i];
            }
            Console.WriteLine("Gennemsnitsalder: " + sum / antal);
            Console.ReadKey();            
        }
    }
}