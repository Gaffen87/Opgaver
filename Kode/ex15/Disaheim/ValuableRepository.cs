using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id) 
        {
            foreach (var valuable in valuables)
            { 
                if (valuable is Merchandise)
                {
                    Merchandise merch = valuable as Merchandise;
                    if (merch.ItemId == id)
                        return merch;
                }
                if (valuable is Course)
                {
                    Course course = valuable as Course;
                    if (course.Name == id) 
                        return course;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach(var valuable in valuables)
            {
                total += valuable.GetValue();
            }
            return total;
        }

        public int Count()
        {
            int count = 0;
            foreach (var valuable in valuables)
            { 
                count++; 
            }
            return count;
        }

        //public void Save()
        //{
        //    string line;
        //    using StreamWriter save = new StreamWriter("ValuableRepository.txt");
        //    foreach (var valuable in valuables)
        //    {
        //        if (valuable is Book)
        //        {
        //            Book book = valuable as Book;
        //            line = $"Book;{book.ItemId};{book.Title};{book.Price}";
        //            save.WriteLine(line);
        //        }
        //        else if (valuable is Amulet)
        //        {
        //            Amulet amulet = valuable as Amulet;
        //            line = $"Amulet;{amulet.ItemId};{amulet.Quality};{amulet.Design}";
        //            save.WriteLine (line);
        //        }
        //        else if (valuable is Course)
        //        {
        //            Course course = valuable as Course;
        //            line = $"Course;{course.Name};{course.DurationInMinutes}";
        //            save.WriteLine(line);
        //        }
        //    }
        //}

        public void Save(string fileName = "ValuableRepository.txt")
        {
            string line;
            using StreamWriter save = new StreamWriter(fileName);
            foreach (var valuable in valuables)
            {
                if (valuable is Book)
                {
                    Book book = valuable as Book;
                    line = $"Book;{book.ItemId};{book.Title};{book.Price}";
                    save.WriteLine(line);
                }
                else if (valuable is Amulet)
                {
                    Amulet amulet = valuable as Amulet;
                    line = $"Amulet;{amulet.ItemId};{amulet.Quality};{amulet.Design}";
                    save.WriteLine(line);
                }
                else if (valuable is Course)
                {
                    Course course = valuable as Course;
                    line = $"Course;{course.Name};{course.DurationInMinutes}";
                    save.WriteLine(line);
                }
            }
        }

        //public void Load()
        //{
        //    string line;
        //    string[] split;
        //    using StreamReader load = new StreamReader("ValuableRepository.txt");
        //    line = load.ReadLine();
        //    while (line != null)
        //    {
        //        split = line.Split(";");
        //        if (split[0] == "Book")
        //        {
        //            Book book = new Book(split[1], split[2], double.Parse(split[3]));
        //            valuables.Add(book);
        //            line = load.ReadLine();
        //        }
        //        else if (split[0] == "Amulet")
        //        {
        //            Amulet amulet = new Amulet(split[1], Enum.Parse<Level>(split[2]), split[3]);
        //            valuables.Add(amulet);
        //            line = load.ReadLine();
        //        }
        //        else if (split[0] == "Course")
        //        {
        //            Course course = new Course(split[1], int.Parse(split[2]));
        //            valuables.Add(course);
        //            line = load.ReadLine();
        //        }
        //    }
        //}

        public void Load(string fileName = "ValuableRepository.txt")
        {
            string line;
            string[] split;
            using StreamReader load = new StreamReader(fileName);
            line = load.ReadLine();
            while (line != null)
            {
                split = line.Split(";");
                if (split[0] == "Book")
                {
                    Book book = new Book(split[1], split[2], double.Parse(split[3]));
                    valuables.Add(book);
                    line = load.ReadLine();
                }
                else if (split[0] == "Amulet")
                {
                    Amulet amulet = new Amulet(split[1], Enum.Parse<Level>(split[2]), split[3]);
                    valuables.Add(amulet);
                    line = load.ReadLine();
                }
                else if (split[0] == "Course")
                {
                    Course course = new Course(split[1], int.Parse(split[2]));
                    valuables.Add(course);
                    line = load.ReadLine();
                }
            }
        }
    }
}
