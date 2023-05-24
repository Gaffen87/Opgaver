using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EX31øvelse4
{
	public class Student : Observer
	{
		private Academy subject;

        public string? Message { get; set; }
        public string? Name { get; }
		
		public Student(Academy subject, string name)
		{
			this.subject = subject;
			this.Name = name;
		}

        public override void Update()
		{
			this.Message = subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {subject.Name}");
        }
	}
}
