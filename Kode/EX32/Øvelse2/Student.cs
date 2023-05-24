using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
	public class Student : Person, IObserver
	{
		private Academy academy;
        public string? Message { get; set; }

        public Student(Academy academy, string name) : base(name) 
		{
			this.academy = academy;
		}

		public void Update()
		{
			Message = academy.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {academy.Name}");
        }
	}
}
