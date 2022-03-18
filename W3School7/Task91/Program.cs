using System;

namespace Task91
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 15, 23, 25, 19, 0 };
            int[] arr2 = new int[] { 7, 3, 45, 76, 20, 0, 20, 10 };
            int[] arr3 = new int[] { 10, 2, 3, 6, 7, 10 };
            int[] arr4 = new int[] { 1, 3, 4, 5, 7, 8, 9, 17 };

            Console.WriteLine(SumArr(arr1));
            Console.WriteLine(SumArr(arr2));
            Console.WriteLine(SumArr(arr3));
            Console.WriteLine(SumArr(arr4));
        }

        static int SumArr(int[] arr)
        {
            int counter = 0;
            foreach (var item in arr)
            {
                counter += item;
            }
            return counter;
        }
    }
}
