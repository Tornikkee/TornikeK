using System;

namespace Task108
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 7, 87, 90, 32, 3, 14, 57 };
            int[] arr2 = new int[] { 23, 45, 67, 98, 100, 0, 12, 3, 71 };
            int[] arr3 = new int[] { 15 };
            int[] arr4 = new int[] { 28, 19 };

            var array1 = NewArr(arr1);
            var array2 = NewArr(arr2);
            var array3 = NewArr(arr3);
            var array4 = NewArr(arr4);

            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            foreach (var item in array3)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            foreach (var item in array4)
            {
                Console.Write(item + " ");
            }
        }

        static int[] NewArr(int[] arr)
        {
            if(arr.Length < 2)
            {
                return arr;
            }
            else
            {
                int[] arr1 = new int[2];
                arr1[0] = arr[0];
                arr1[1] = arr[1];
                return arr1;
            }
        }
    }
}
