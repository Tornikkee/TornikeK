using System;

namespace Task52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 5 };
            int[] arr2 = new int[] { 0, 3, 8 };
            int[] arr3 = new int[] { -1, 0, 2 };

            var arr = NewArr(arr1, arr2, arr3);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static int[] NewArr(int[] arr1, int[] arr2, int[] arr3)
        {
            int[] arr = new int[3];

            arr[0] = arr1[1];
            arr[1] = arr2[1];
            arr[2] = arr3[1];

            return arr;
        }
    }
}
