using System.ComponentModel;

namespace Øvelse3
{


	public class Academy : Organization, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		private string message;
		public string Message
		{
			get => message;
			set
			{
				message = value;
				OnPropertyChanged();
			}
		}

		public Academy(string name, string address) : base(name)
		{
			this.Address = address;
		}

		public void OnPropertyChanged()
		{
			PropertyChanged?.Invoke(this, null);
		}
	}
}
