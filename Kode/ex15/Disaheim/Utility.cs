using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace Disaheim
{
    public class Utility
    {
        //public double GetValueOfBook(Book book)
        //{
        //    return book.Price;
        //}

        //public double GetValueOfAmulet(Amulet amulet)
        //{
        //    if (amulet.Quality == Level.low)
        //    {
        //        return 12.5;
        //    }
        //    else if (amulet.Quality == Level.medium)
        //    {
        //        return 20.0;
        //    }
        //    else
        //    {
        //        return 27.5;
        //    }
        //}
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20.0;
        public double HighQualityValue = 27.5;
        public double CourseHourValue = 875.0;

        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Amulet)
            {
                Amulet amulet = merchandise as Amulet;
                if (amulet.Quality == Level.low)
                {
                    return LowQualityValue;
                }
                else if (amulet.Quality == Level.medium)
                {
                    return MediumQualityValue;
                }
                else
                {
                    return HighQualityValue;
                }
            }            
            else if (merchandise is Book)
            {
                Book book = merchandise as Book;
                return book.Price;
            }
            else
                return 0;
        }

        public double GetValueOfCourse(Course course)
        {
            int a = course.DurationInMinutes / 60;
            int b = course.DurationInMinutes % 60;
            if (b != 0)
                return CourseHourValue * (a + 1);
            else
                return CourseHourValue * a;
        }

    }
}
