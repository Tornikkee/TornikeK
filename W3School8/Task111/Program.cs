using System;

namespace Task111
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 7, 87, 90, 32, 3, 14, 57 };
            int[] arr2 = new int[] { 23, 45, 67, 98, 100, 0, 12, 3, 71 };
            int[] arr3 = new int[] { };
            int[] arr4 = new int[] { 17, 19 };

            Console.WriteLine(Sum(arr1));
            Console.WriteLine(Sum(arr2));
            Console.WriteLine(Sum(arr3));
            Console.WriteLine(Sum(arr4));
        }

        static int Sum(int[] arr)
        {
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 17)
                {
                    arr[i] = 0;
                }
                counter += arr[i];
            }
            return counter;
        }
    }
}
