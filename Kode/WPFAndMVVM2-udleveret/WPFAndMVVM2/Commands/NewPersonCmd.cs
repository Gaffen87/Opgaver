using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFAndMVVM2.ViewModels;
using WPFAndMVVM2;
using System.Windows;

namespace WPFAndMVVM2.Commands
{
	public class NewPersonCmd : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			if (parameter is MainViewModel mvm)
			{
				mvm.AddDefaultPerson();
				MainWindow main = (MainWindow)Application.Current.MainWindow;
				main.lbPersons.ScrollIntoView(mvm.SelectedPerson);
			}
		}
	}
}
