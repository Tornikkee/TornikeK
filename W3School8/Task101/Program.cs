using System;

namespace Task101
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 5, 7 };
            int[] arr2 = new int[] { 1, 5, 5 };
            int[] arr3 = new int[] { 3, 6, 9 };

            NewArr(arr1);
            NewArr(arr2);
            NewArr(arr3);

            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            foreach (var item in arr3)
            {
                Console.Write(item + " ");
            }
        }

        static int[] NewArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(i < arr.Length - 1)
                {
                    if(arr[i] == 5 && arr[i + 1] == 7)
                    {
                        arr[i + 1] = 1;
                    }
                }
            }
            return arr;
        }
    }
}
