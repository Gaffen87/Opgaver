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
            StreamWriter Save = new StreamWriter(_dataFileName);
            Save.WriteLine(person.MakeTitle());
            Save.Close();
        }

        public Person LoadPerson()
        {
            StreamReader Load = new StreamReader(_dataFileName);
            string str = Load.ReadToEnd();

            string[] split = str.Split(";");

            Person person = new Person(split[0], DateTime.Parse(split[1]), double.Parse(split[2]), bool.Parse(split[3]), int.Parse(split[4]));

            return person;
        }
    }
}
