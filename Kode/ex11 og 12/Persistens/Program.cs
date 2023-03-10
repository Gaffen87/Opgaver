namespace Persistens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person("William Jensen", new DateTime(1975, 8, 24), 175.9, false, 2),
                new Person("Alfred Nielsen", new DateTime(1991, 3, 12), 185.0, true, 3),
                new Person("Oskar Hansen", new DateTime(2005, 11, 9), 183.2, true, 1),
                new Person("Emma Pedersen", new DateTime(2013, 9, 25), 113.7, false, 0),
                new Person("Alma Andersen", new DateTime(1982, 1, 5), 169.9, false, 2),
                new Person("Clara Christensen", new DateTime(1999, 7, 13), 165.3, true, 0),
            };

            DataHandler handler = new DataHandler("Data.txt");

            handler.SavePersons(persons);

            Console.WriteLine("Writing Persons: ");
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].MakeTitle());
            }

            Person[] persons2 = handler.LoadPersons();

            for (int i = 0; i < persons2.Length; i++)
            {
                Console.WriteLine(persons2[i].MakeTitle());
            }

            Console.ReadLine();
        }
    }
}
