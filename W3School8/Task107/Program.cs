using System;

namespace Task107
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 7, 87, 90, 32, 3, 14, 57 };
            int[] arr2 = new int[] { 23, 45, 67, 98, 100, 0, 12, 3, 71 };
            int[] arr3 = new int[] { 15 };
            int[] arr4 = new int[] { 28, 19 };

            Console.WriteLine(FindLargest(arr1));
            Console.WriteLine(FindLargest(arr2));
            Console.WriteLine(FindLargest(arr3));
            Console.WriteLine(FindLargest(arr4));
        }

        static int FindLargest(int[] arr)
        {
            int first = 0;
            int middle = 0;
            int last = 0;

            first = arr[0];
            last = arr[arr.Length - 1];
            if(arr.Length % 2 == 0)
            {
                middle = (arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2;
            }
            else if(arr.Length % 2 == 1)
            {
                middle = arr[(arr.Length - 1) / 2];
            }

            if(first > middle && first > last)
            {
                return first;
            }
            else if(middle > first && middle > last)
            {
                return middle;
            }
            else
            {
                return last;
            }
        }
    }
}
