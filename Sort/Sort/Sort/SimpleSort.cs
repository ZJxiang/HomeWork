using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    public class SimpleSort
    {
        public static Int32[] sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int m = i;
                int min = numbers[i];
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        m = j;
                    }
                }
                int tmp = numbers[i];
                numbers[i] = min;
                numbers[m] = tmp;
            }
            return numbers;
        }
    }
}
