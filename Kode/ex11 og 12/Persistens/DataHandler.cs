using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class DataHandler
    {
        private string _dataFileName;
            public string DataFileName
            { 
                get { return _dataFileName; } 
            }

        public DataHandler(string dataFileName)
        {
            _dataFileName = dataFileName;
        }

        public void SavePerson(Person person)
        {
            using StreamWriter Save = new StreamWriter(_dataFileName);
            Save.WriteLine(person.MakeTitle());
        }

        public Person LoadPerson()
        {
            using StreamReader Load = new StreamReader(_dataFileName);
            string str = Load.ReadToEnd();

            string[] split = str.Split(";");

            Person person = new Person(split[0], DateTime.Parse(split[1]), double.Parse(split[2]), bool.Parse(split[3]), int.Parse(split[4]));

            return person;
        }

        public void SavePersons(Person[] persons)
        {
            using StreamWriter Save = new StreamWriter(_dataFileName);    
            for (int i = 0; i < persons.Length; i++)
            {
                Save.WriteLine(persons[i].MakeTitle());
            }                       
        }

        public Person[] LoadPersons()
        {
            int arraySize = 0;
            using StreamReader Read = new StreamReader(_dataFileName);
            {
                while (Read.ReadLine() != null) 
                {
                    arraySize++;
                }
            }

            Person[] persons = new Person[arraySize];

            int i = 0;

            using StreamReader Load = new StreamReader(_dataFileName);
            string line = Load.ReadLine();
            while (line != null)
            {
                string[] split = line.Split(";");
                Person person = new Person(split[0], DateTime.Parse(split[1]), double.Parse(split[2]), bool.Parse(split[3]), int.Parse(split[4]));
                persons[i] = person;
                i++;
                line = Load.ReadLine();
            }

            return persons;
        }
    }
}
