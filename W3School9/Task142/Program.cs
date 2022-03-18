using System;

namespace Task142
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4 };
            int[] arr2 = new int[] { 100, 15, 23, 45, 0, 19, 407 };

            MultipliedArr(arr1);
            MultipliedArr(arr2);

            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }
        }

        static int[] MultipliedArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i] * arr[i];
            }
            return arr;
        }
    }
}
