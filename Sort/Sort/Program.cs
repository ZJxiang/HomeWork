using System;
using Sort.Util;

namespace Sort
{
    public class TestSort
    {
        public static void Main(string[] args)
        {

            //int[] numbers=SortUtil.Read();
            ////int[] bubblenumbers=BubbleSort.sort(numbers);
            ////int[] insertnumbers = InsertSort.sort(numbers);
            ////int[] shellnumbers = ShellSort.sort(numbers);
            ////int[] simplenumbers = SimpleSort.sort(numbers);
            //int[] merge = MergeSort.Sort(numbers);
            //SortUtil.Write(merge);
            ////SortUtil.Write(bubblenumbers);
            ////SortUtil.Write(simplenumbers);
            Console.WriteLine("按1，2，3，4，5分别选择冒泡，插入，希尔，简单，归并排序法");
            while (true)
            {
                SortUtil.SelectASort();
            }
        }
    }
}
