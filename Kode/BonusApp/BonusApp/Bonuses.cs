using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
	public class Bonuses
	{
		public static double TenPercent(double amount) // returnerer 10% af værdien
		{
			return amount * 0.1;
		}

		public static double FlatTwoIfAmountMoreThanFive(double amount) // returnerer 2 hvis værdi over 5 og ellers 0.
		{
			if (amount > 5)
				return 2.0;
			else
				return 0.0;
		}
	}
}
