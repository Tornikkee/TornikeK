using System;

namespace Task95
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, 7, 37, 45 };
            int[] arr2 = new int[] { 2, 5, 89, 10, 5 };

            var arr = NewArr(arr1, arr2);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static int[] NewArr(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[2];
            arr3[0] = arr1[2];
            arr3[1] = arr2[2];
            return arr3;
        }
    }
}
