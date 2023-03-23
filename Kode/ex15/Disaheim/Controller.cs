using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public ValuableRepository ValuableRepo { get; set; }

        public Controller() { }

        public void AddToList(IValuable valuable)
        {
            ValuableRepo.AddValuable(valuable);
        }

        //public List<Book> Books { get; set; }

        //public List<Amulet> Amulets { get; set; }

        //public List<Course> Courses { get; set; }

        //public Controller()
        //{
        //    Books = new List<Book>();
        //    Amulets = new List<Amulet>();
        //    Courses = new List<Course>();
        //}

        //public void AddToList(Book book)
        //{
        //    Books.Add(book);
        //}

        //public void AddToList(Amulet amulet)
        //{
        //    Amulets.Add(amulet);
        //}

        //public void AddToList(Course course)
        //{
        //    Courses.Add(course);
        //}
    }
}
