using Sort.Sort;
using System;

namespace Sort.Util
{
    public class SortUtil
    {
        //输入数字按回车进入对应的排序方法
        public static void SelectASort()
        {
            string i = Console.ReadLine().Trim();
            switch (i)
            {
                case "1":
                    {
                        Console.WriteLine("<*******冒泡排序法*******>");
                        int[] numbers = SortUtil.Read();
                        int[] bubblenumbers = BubbleSort.sort(numbers);
                        SortUtil.Write(bubblenumbers);
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("<*******插入排序法*******>");
                        int[] numbers = SortUtil.Read();
                        int[] insertnumbers = InsertSort.sort(numbers);
                        SortUtil.Write(insertnumbers);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("<*******希尔排序法*******>");
                        int[] numbers = SortUtil.Read();
                        int[] shellnumbers = ShellSort.sort(numbers);
                        SortUtil.Write(shellnumbers);
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("<*******简单排序法*******>");
                        int[] numbers = SortUtil.Read();
                        int[] simplenumbers = SimpleSort.sort(numbers);
                        SortUtil.Write(simplenumbers);
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("<*******归并排序法*******>");
                        int[] numbers = SortUtil.Read();
                        int[] mergesort = MergeSort.sort(numbers);
                        SortUtil.Write(mergesort);
                        break;
                    }
            }
        }
        //输入需要排序的数字，以空格隔开，回车确定
        public static int[] Read()
        {
            Console.WriteLine("请输入想要进行比较的数字，以空格隔开，回车确定");
            string str_numbers = Console.ReadLine();
            string[] str_number = str_numbers.Trim().Split(' ');
            int[] numbers = new int[str_number.Length];
            for (int i = 0; i < str_number.Length; i++)
            {
                numbers[i] = Convert.ToInt32(str_number[i]);
            }
            return numbers;
        }

        //交换数字
        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        //输出
        public static void Write(int[] numbers)
        {
            for (int t = 0; t < numbers.Length; t++)
            {
                Console.Write(numbers[t] + " ");
            }
            Console.WriteLine("\n按1，2，3，4，5分别选择冒泡，插入，希尔，简单，归并排序法");
        }
    }
}
