using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    public class MergeSort
    {
        public static int[] sort(int[] numbers)
        {
            Msort(numbers, numbers, 1, numbers.Length - 1);
            return numbers;
        }
        static void Merge(int[] SR, int[] TR, int i, int m, int n)
        {
            int j, k;
            for (j = m + 1, k = i; i <= m && j <= n; ++k)
            {
                if (SR[i] <= SR[j])
                    TR[k] = SR[i++];
                else TR[k] = SR[j++];
            }
            if (i <= m)
            {
                for (; i <= m; i++, k++) TR[k] = SR[i];
            }
            if (j <= n)
            {
                for (; j <= n; j++, k++) TR[k] = SR[j];
            }
        }
        static void Msort(int[] SR, int[] TR1, int s, int t)
        {
            int[] TR2 = new int[TR1.Length];
            int m;
            if (s == t) TR1[s] = SR[s];
            else
            {
                m = (s + t) / 2;
                Msort(SR, TR2, s, m);
                Msort(SR, TR2, m + 1, t);
                Merge(TR2, TR1, s, m, t);
            }
        }
    }
}