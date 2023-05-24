using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
	public interface ISubject
	{
		void Attach(IObserver o);
		void Detach(IObserver o);
		void Notify();
	}
}
