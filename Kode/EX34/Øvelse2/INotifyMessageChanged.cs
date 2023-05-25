using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
	public interface INotifyMessageChanged
	{
		public event EventHandler MessageChanged;
	}
}
