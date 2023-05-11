using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandBindListBox.ViewModel
{
	public class DeletePerson : ICommand
	{
		public event EventHandler? CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public bool CanExecute(object? parameter)
		{
			bool result = true;

			if(parameter is MainViewModel mvm)
			{
				if(mvm.SelectedProduct == null)
				{
					result = false;
				}
			}
			return result;
		}

		public void Execute(object? parameter)
		{
			if(parameter is MainViewModel mvm)
			{
				mvm.Remove();
				mvm.ProductsVM.Remove(mvm.SelectedProduct);
			}
		}
	}
}
