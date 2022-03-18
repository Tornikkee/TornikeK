using System;

namespace Task127
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 20, -30, -40, 50 };
            int[] arr2 = new int[] { 10, 20, -30, -40, 50, 99, -100 };

            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            ShiftedArr(arr1);
            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            ShiftedArr(arr2);
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }
        }

        static int[] ShiftedArr(int[] arr)
        {
            int temp = 0;
            temp = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = temp;

            return arr;
        }
    }
}
