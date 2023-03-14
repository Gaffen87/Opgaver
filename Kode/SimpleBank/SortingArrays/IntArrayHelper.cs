using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArrays
{
    public class IntArrayHelper
    {
        public void Sort(int[] intArray)
        {
            int temp = 0;
            for (int i = 0; i < intArray.Length-1; i++)
            {
                for (int j = i+1; j < intArray.Length; j++)
                {
                    if (intArray[j] < intArray[i])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
        }

        public void Reverse(int[] intArray) 
        {
            int temp = 0;
            for (int i = 0;i < intArray.Length-1;i++)
            {
                for (int j = i+1;j < intArray.Length;j++)
                {
                    if (intArray[j] > intArray[i])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
        }
    }
}
