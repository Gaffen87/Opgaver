namespace _2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hej 3 + 3 er 9";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 48 && str[i] <= 57)
                {
                    Console.Write("<{0}> ", i);
                    Console.Write(str[i]);
                    Console.WriteLine(" (ciffer)");
                }
                else if (str[i] == 43 || str[i] == 45)
                {
                    Console.Write("<{0}> ", i);
                    Console.Write(str[i]);
                    Console.WriteLine(" (operator)");
                }
                else
                {
                    Console.Write("<{0}> ", i);
                    Console.Write(str[i]);
                    Console.WriteLine(" (ukendt)");
                }
            }

            Console.ReadKey();
        }
    }
}