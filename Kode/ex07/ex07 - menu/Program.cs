namespace ex07___menu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu mainMenu = new Menu();

            mainMenu.AddMenuItem("1. Gør dit");
            mainMenu.AddMenuItem("2. Gør dat");
            mainMenu.AddMenuItem("3. Gør noget");
            mainMenu.AddMenuItem("4. Få svaret på livet, universet og alting");

            mainMenu.Show();

            bool b = true;
            while (b)
            {
                int choice = mainMenu.SelectMenuItem();

                switch (choice)
                {
                    case 0:
                        b = false;
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Gør dit");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.Show();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Gør dat");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.Show();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Gør noget");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.Show();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("42");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.Show();
                        break;
                }
            }
        }
    }
}