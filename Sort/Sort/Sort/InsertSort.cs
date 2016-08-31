using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    public class InsertSort
    {
        //插入排序
        public static int[] sort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    int j = 0;
                    int tmp = numbers[i];
                    for (j = i - 1; j >= 0 && (tmp < numbers[j]); j--)
                    {
                        numbers[j + 1] = numbers[j];
                    }
                    numbers[j + 1] = tmp;
                }
            }
            return numbers;
        }
    }
}