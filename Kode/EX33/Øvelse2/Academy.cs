namespace Øvelse3
{
	public class Academy : Organization
	{
		public NotifyHandler MessageChanged;

		private string message;
		public string Message 
		{ 
			get => message;
			set
			{
				message = value;
				OnMessageChanged();
			}
		}

		public Academy(string name, string address) : base(name)
		{
			this.Address = address;
		}

		public void OnMessageChanged()
		{
			MessageChanged();
		}
	}
}
