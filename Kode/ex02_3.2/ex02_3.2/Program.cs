namespace ex02_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Indtast navn: ");
                string name = Console.ReadLine();

                Console.WriteLine("Indtast alder: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age >= 0 && age < 13)
                {
                    Console.WriteLine(name + " er et barn");
                }
                else if (age > 12 && age < 20)
                {
                    Console.WriteLine(name + " er en teenager");
                }
                else if (age > 19 && age < 26)
                {
                    Console.WriteLine(name + " er en studerende");
                }
                else if (age == 35)
                {
                    Console.WriteLine(name + " er den perfekte alder");
                }
                else if (age > 25 && age < 68)
                {
                    Console.WriteLine(name + " er i arbejde");
                }
                else if (age > 66)
                {
                    Console.WriteLine(name + " er en pensionist");
                }
            }
        }
    }
}