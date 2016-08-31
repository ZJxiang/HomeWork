using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sort.Util;

namespace Sort.Sort
{
    public class BubbleSort
    {
        public static Int32[] sort(int[] int_numbers)
        {

            for (int i = 0; i < int_numbers.Length; i++)
            {
                for (int j = int_numbers.Length - 1; j > i; j--)
                {
                    if (int_numbers[j] < int_numbers[j - 1])
                    {
                        SortUtil.Swap(ref int_numbers[j], ref int_numbers[j - 1]);
                    }
                }
            }
            return int_numbers;
        }
    }
}