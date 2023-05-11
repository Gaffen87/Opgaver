using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WPFAndMVVM2.Commands;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

		private PersonRepository personRepo = new PersonRepository();

		public ObservableCollection<PersonViewModel> PersonsVM { get; set; }

        private PersonViewModel selectedPerson;

        public PersonViewModel SelectedPerson
        {
            get { return selectedPerson; }
            set 
            {
                selectedPerson = value; 
                OnPropertyChanged(nameof(SelectedPerson));
            }
        }

        public ICommand NewPersonCommand { get; set; } = new NewPersonCmd();

        public ICommand DeletePersonCommand { get; set; } = new DeletePersonCmd();

        public MainViewModel()
        {
            PersonsVM = new ObservableCollection<PersonViewModel>();
            foreach (var person in personRepo.GetAll()) 
            {
                PersonViewModel pvm = new(person);
                PersonsVM.Add(pvm);
            }
        }

        public void AddDefaultPerson()
        {
			Person person = new()
			{
				FirstName = "Specify FirstName",
				LastName = "Specify LastName",
				Age = 0,
				Phone = "Specify Phone"
			};

			personRepo.Add(person.FirstName, person.LastName, person.Age, person.Phone);
            PersonViewModel newPerson = new(person);
            PersonsVM.Add(newPerson);
            SelectedPerson = newPerson;
        }

        public void DeleteSelectedPerson()
        {
            SelectedPerson.DeletePerson(personRepo);
            PersonsVM.Remove(SelectedPerson);
        }

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

    }
}
