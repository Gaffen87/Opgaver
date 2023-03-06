namespace _2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indlæs tekst: ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    char ch = str[i];
                    Console.WriteLine("                             {0}. bogstav er: {1}", i, ch);
                }
                else
                {
                    char ch = str[i];
                    Console.WriteLine("{0}. bogstav er: {1}", i, ch);
                }
            }
            Console.ReadKey();
        }
    }
}