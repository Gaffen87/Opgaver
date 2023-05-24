using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternEX31
{
	public class ConcreteSubject : Subject
	{
		private int state;

		public int State
		{
			get { return state; }
			set 
			{ 
				state = value;
				Notify();
			}
		}
    }
}
