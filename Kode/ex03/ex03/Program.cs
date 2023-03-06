namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Aske";

            char c = Convert.ToChar(Console.ReadLine());
            
            if (tekst.IndexOf(c) != -1)
            {
                Console.WriteLine(tekst.IndexOf(c));
            }
            else
            {
                Console.WriteLine("Character not found!");
            }

            Console.ReadKey();
        }
    }
}