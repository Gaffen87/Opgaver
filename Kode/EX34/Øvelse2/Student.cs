using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
	public class Student : Person, IObserver
	{
        public string? Message { get; set; }

        public Student(string name) : base(name) { }

		public void Update(object sender, EventArgs e)
		{
			if (sender is Academy academy)
			{
				Message = academy.Message;
				Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {academy.Name}");
			}
        }
	}
}
