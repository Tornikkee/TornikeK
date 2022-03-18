using System;

namespace Task103
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 4, 7, 18, 21, 35 };
            int[] arr2 = new int[] { 41, 100, 37, 12, 15 };

            var arr3 = FindMiddle(arr1);
            var arr4 = FindMiddle(arr2);

            foreach (var item in arr3)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            foreach (var item in arr4)
            {
                Console.Write(item + " ");
            }
        }

        static int[] FindMiddle(int[] arr)
        {
            if (arr.Length % 2 == 1)
            {
                int[] arr1 = new int[1];
                arr1[0] = arr[(arr.Length - 1) / 2];
                return arr1;
            }
            else
            {
                int[] arr2 = new int[2];
                arr2[0] = arr[(arr.Length / 2) - 1];
                arr2[1] = arr[arr.Length / 2];
                return arr2;
            }
        }
    }
}
