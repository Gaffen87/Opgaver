using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_4._1
{
    public class SockCounter
    {
        public int SockPairs(int[] socks)
        {
            int sockCount;
            int sum = 0;
            int[] temp = new int[socks.Length];

            for (int i = 0; i < socks.Length; i++)
            {
                sockCount = 0;
                if (!temp.Contains(socks[i]))
                {
                    temp[i] = socks[i];
                    for (int x = 0; x < socks.Length; x++)
                    {
                        if (socks[x] == temp[i])
                        {
                            sockCount++;
                        }
                        if (sockCount == 2)
                        {
                            sum++;
                            sockCount = 0;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
