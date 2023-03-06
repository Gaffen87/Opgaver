namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Aske Lysgaard";
            int counter = 0;

            while(counter < tekst.Length)
            {
                Console.WriteLine(tekst[counter]);
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine(tekst[counter]);
                counter++;
            }
            while (counter < tekst.Length);
            

        Console.ReadKey();
        }
    }
}