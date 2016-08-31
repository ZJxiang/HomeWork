using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    public class ShellSort
    {
        //希尔排序
        public static int[] sort(int[] numbers)
        {
            for (int i = numbers.Length / 2; i > 0; i = i / 2)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    int tmp = numbers[j];
                    if (tmp < numbers[j - i])
                    {
                        //numbers[j] = numbers[j - i];
                        //numbers[j-i] = tmp;

                        for (int k = 0; k < j; k += i)
                        {
                            if (tmp < numbers[k])
                            {
                                tmp = numbers[k];
                                numbers[k] = numbers[j];
                                numbers[j] = tmp;
                            }
                        }
                    }
                }
            }
            return numbers;
        }
    }
}
