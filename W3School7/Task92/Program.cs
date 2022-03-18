using System;

namespace Task92
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, -30, -40 };
            int[] arr3 = new int[] { 10, 20, -30, -40, 50, 99 };

            var arr1 = ChangeArr(arr);

            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }

            var arr2 = ChangeArr(arr3);
            Console.WriteLine("\n");

            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }
        }

        static int[] ChangeArr(int[] arr)
        {
            int temp = 0;
            temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(i < arr.Length - 1)
                {
                    arr[i] = arr[i + 1];
                }
                if(i == arr.Length - 1)
                {
                    arr[i] = temp;
                }
            }
            return arr;
        }
    }
}
