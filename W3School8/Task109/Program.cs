using System;

namespace Task109
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 7, 87, 90, 32, 3, 14, 57 };
            int[] arr2 = new int[] { 23, 45, 67, 98, 100, 0, 12, 3, 71 };
            int[] arr3 = new int[] { 15 };
            int[] arr4 = new int[] { 28, 19 };

            Console.WriteLine(CountEven(arr1));
            Console.WriteLine(CountEven(arr2));
            Console.WriteLine(CountEven(arr3));
            Console.WriteLine(CountEven(arr4));
        }

        static int CountEven(int[] arr)
        {
            int ctr = 0;
            foreach (var item in arr)
            {
                if(item % 2 == 0)
                {
                    ctr++;
                }
            }
            return ctr;
        }
    }
}
