using System;

namespace Task110
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 7, 87, 90, 32, 3, 14, 57 };
            int[] arr2 = new int[] { 23, 45, 67, 98, 100, 0, 12, 3, 71 };
            int[] arr3 = new int[] { 15 };
            int[] arr4 = new int[] { 28, 19 };

            Console.WriteLine(Difference(arr1));
            Console.WriteLine(Difference(arr2));
            Console.WriteLine(Difference(arr3));
            Console.WriteLine(Difference(arr4));
        }

        static int Difference(int[] arr)
        {
            int max = 0;
            int min = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == 0)
                {
                    min = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return max - min;
        }
    }
}
