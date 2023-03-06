namespace Øv5_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Min fantastiske menu:\n");
                Console.WriteLine("1. Gør dit");
                Console.WriteLine("2. Gør dat");
                Console.WriteLine("3. Gør noget");
                Console.WriteLine("4. Få svaret på livet, universet og alting");
                Console.WriteLine("5. Afslut\n");
                Console.WriteLine("(Tryk menupunkt 1, 2, 3, 4 eller 5)");

                int choice = Convert.ToInt32(Console.ReadLine());
                string message = "";

                switch (choice)
                {
                    case 1:
                        message = "Gør dit";
                        break;
                    case 2:
                        message = "Gør dat";
                        break;
                    case 3:
                        message = "Gør noget";
                        break;
                    case 4:
                        message = "42";
                        break;
                    case 5:
                        Console.WriteLine("Vil du afslutte? y/n?");
                        char slut = Convert.ToChar(Console.ReadLine());
                        if (slut == 'y')
                        {
                            return;
                        }
                        break;
                    default:
                        message = "Forkert valg!";
                        break;
                }

            Console.WriteLine("\nPunkt {0} er valgt: {1}\n", choice, message);
            Console.Write("Tryk på en tast for at komme tilbage til menuen");
            Console.ReadKey();
            Console.Clear();
            }
            
        }
    }
}