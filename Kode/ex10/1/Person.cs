using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string _name;
        public string Name
            { 
                get { return _name; } 
                set { _name = value; } 
            }

        private DateTime _birthDate;
            public DateTime BirthDate
            { 
                get { return _birthDate; }
                set { _birthDate = value; } 
            }

        private double _height;
            public double Height
            { 
                get { return _height; } 
                set { _height = value; } 
            }

        private bool _isMarried;
            public bool IsMarried
            {
                get { return _isMarried; }
                set { _isMarried = value; }
            }

        private int _noOfChildren;
            public int NoOfChildren
            {
                get { return _noOfChildren; }
                set { _noOfChildren = value; }
            }

        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            _name = name;
            _birthDate = birthDate;
            _height = height;
            _isMarried = isMarried;
            _noOfChildren = noOfChildren;
        }

        public string MakeTitle()
        {
            return $"{_name};{_birthDate};{_height};{_isMarried};{_noOfChildren}";
        }
    }
}
