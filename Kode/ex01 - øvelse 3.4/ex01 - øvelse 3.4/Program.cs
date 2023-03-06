namespace ex01___øvelse_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Navn: " + name);

            Console.Write("Indtast tal 1: ");
            string tal1 = Console.ReadLine();

            Console.Write("Indtast tal 2: ");
            string tal2 = Console.ReadLine();

            Console.WriteLine(name + " er " + int.Parse(tal1) + int.Parse(tal2) + " år gammel");
        }
    }
}