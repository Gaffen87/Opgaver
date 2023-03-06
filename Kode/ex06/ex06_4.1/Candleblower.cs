using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_4._1
{
    public class Candleblower
    {
        public int Blow(int[] candle)
        {
            int high = 0;
            int sum = 0;

            for (int i = 0; i < candle.Length; i++)
            {
                if (candle[i] > high)
                {
                    high = candle[i];
                }
            }

            for (int i = 0; i < candle.Length; i++)
            {
                if (candle[i] == high)
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}
