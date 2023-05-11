using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommandBindListBox.Model;

namespace CommandBindListBox.ViewModel
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public ProductRepo repo = new();

		public ObservableCollection<ProductViewModel> ProductsVM { get; set; }

		public MainViewModel()
		{
			ProductsVM = new ObservableCollection<ProductViewModel>();
			foreach (var item in repo.GetAll())
			{
				ProductViewModel pvm = new(item);
				ProductsVM.Add(pvm);
			}
		}

		private ProductViewModel selectedProduct;

		public ProductViewModel SelectedProduct
		{
			get { return selectedProduct; }
			set 
			{ 
				selectedProduct = value; 
				OnPropertyChanged(nameof(SelectedProduct));
			}
		}

		public void Remove()
		{
			SelectedProduct.Remove(repo);
		}
		
        public ICommand NewProductCmd { get; set; } = new NewProduct();
		public ICommand DeletePersonCmd { get; set; } = new DeletePerson();

        public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

    }
}
