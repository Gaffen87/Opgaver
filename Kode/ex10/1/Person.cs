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

                set 
                { 
                    if (value.Length > 0)
                    {
                        _name = value;
                    }
                    else
                    {
                        throw new Exception("Fejl! Et navn skal indeholde mindst 1 bogstav");
                    }
                } 
            }

        private DateTime _birthDate;
            public DateTime BirthDate
            { 
                get { return _birthDate; }
            
                set
                {
                    DateTime min = new DateTime(1900, 1, 1);
                    if (value > min) 
                    {
                        _birthDate = value;
                    }
                    else
                    { 
                        throw new Exception("Fejl! Fødselsdato må ikke være før 1. januar 1900");
                    }
                }
            }

        private double _height;
            public double Height
            { 
                get { return _height; } 
                set 
                {
                    if (value > 0)
                    { 
                        _height = value;
                    }
                    else
                    {
                        throw new Exception("Fejl! Højde skal være over 0");
                    }
                } 
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
                set 
                {
                    if (value >= 0)
                    {
                        _noOfChildren = value;
                    }
                    else
                    {
                        throw new Exception("Fejl! Man kan ikke have negativ antal børn");
                    }
                }
            }

        DateTime min = new DateTime(1900, 1, 1);
        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            if (name.Length == 0 || birthDate < min || height <= 0 || noOfChildren < 0)
            {
                throw new Exception("Fejl! Indtast gyldige oplysninger");
            }
            else
            {
                _name = name;
                _birthDate = birthDate;
                _height = height;
                _isMarried = isMarried;
                _noOfChildren = noOfChildren;
            }

        }

        public Person(string name, DateTime birthDate, double height, bool isMarried) :
            this (name, birthDate, height, isMarried, 0)
        {
            if (name.Length == 0 || birthDate < min || height <= 0)
            {
                throw new Exception("Fejl! Indtast gyldige oplysninger");
            }
        }

        public string MakeTitle()
        {
            return $"{_name};{_birthDate};{_height};{_isMarried};{_noOfChildren}";
        }
    }
}
