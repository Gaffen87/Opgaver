using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommandBindListBox.Model;

namespace CommandBindListBox.ViewModel
{
	public class NewProduct : ICommand
	{

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			if(parameter is MainViewModel mvm)
			{
				Product product = new Product()
				{
					Name = "New Product",
					Price = 0.0
				};

				mvm.repo.Add(product);
				ProductViewModel pvm = new(product);
				mvm.ProductsVM.Add(pvm);
			}
		}
	}
}
