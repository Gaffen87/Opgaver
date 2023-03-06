namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < y; i++)
            {
                Console.Write("#");
                for (int x = 1; x < y; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}