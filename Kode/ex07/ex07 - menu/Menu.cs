using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ex07___menu
{
    public class Menu
    {
        public string Title = new string("Min fantastiske menu");

        private menuItem[] MenuItems = new menuItem[10];

        private int itemCount = 0;

        public void AddMenuItem(string menuTitle)
        {
            menuItem mi = new menuItem(menuTitle);
            MenuItems[itemCount] = mi;
            itemCount++;
        }

        public void Show()
        {
            Console.WriteLine(Title);
            Console.WriteLine();

            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(MenuItems[i].Title);
            }

            Console.WriteLine("\n(Tryk menupunkt eller 0 for at afslutte)");
        }

        public int SelectMenuItem()
        {
            choice:
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 0 && choice <= itemCount)
                {
                    return choice;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Forkert input!");
                    Console.ReadLine();
                    Console.Clear();
                    Show();
                    goto choice;
                }
            }
            catch(Exception)
            {
                Console.Clear();
                Console.WriteLine("Forkert input!");
                Console.ReadLine();
                Console.Clear();
                Show();
                goto choice;
            }
            
        }
    }
}
