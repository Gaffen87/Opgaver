﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
	public interface IObserver
	{
		void Update(object sender, EventArgs e);
	}
}
