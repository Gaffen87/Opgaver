using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person person;

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

        // Properties
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(FullName));
            }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set 
            { 
                lastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(FullName));
            }
        }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
            set 
            {
                OnPropertyChanged(nameof(FullName));
            }
        }

        // Constructor
        public PersonViewModel(Person person)
        {
            this.person = person;
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
            Phone = person.Phone;
        }

        public void DeletePerson(PersonRepository repo)
        {
            repo.Remove(person.Id);
        }
    }
}
