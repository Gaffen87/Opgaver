using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public static double CourseHourValue = 875;

        public Course(string name) : this(name, 0) { }
        public Course(string name, int durationInMinutes) 
        { 
            this.Name = name;
            this.DurationInMinutes = durationInMinutes;
        }

        public override string ToString() 
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

        public double GetValue()
        {
            if (DurationInMinutes > 0)
            {
                return (DurationInMinutes + 59)/60 * CourseHourValue;
            }
            else
                return 0;
        }
    }
}
