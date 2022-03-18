using System;

namespace Task96
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, 7, 9, 25 };
            int[] arr2 = new int[] { 300 };

            var array1 = NewArr(arr1);
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");

            var array2 = NewArr(arr2);
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
        }

        static int[] NewArr(int[] arr)
        {
            if(arr.Length == 1)
            {
                return arr;
            }
            int[] arr1 = new int[2];
            arr1[0] = arr[0];
            arr1[1] = arr[arr.Length - 1];
            return arr1;
        }
    }
}
