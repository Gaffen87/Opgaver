using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAndMVVM1
{
    public class MainViewModel : INotifyPropertyChanged
    {
		private string myLabelText = "Text not set yet";
		public string MyLabelText
		{
			get { return myLabelText; }
			set 
			{
				myLabelText = value; 
				OnPropertyChanged(nameof(MyLabelText));
			}
		}

		private string myTextBoxText = "Text not set yet";
		public string MyTextBoxText
		{
			get { return myTextBoxText; }
			set 
			{
				myTextBoxText = value; 
				OnPropertyChanged(nameof(MyTextBoxText));
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

	}
}
