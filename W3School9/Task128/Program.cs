using System;

namespace Task128
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 5, 7 };
            int[] arr2 = new int[] { 1, 2, 3, 501, 37, 5, 18, 48, 109 };

            var arr3 = FilterArr(arr1);
            var arr4 = FilterArr(arr2);

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

        static int[] FilterArr(int[] arr)
        {
            int ctr = 0;
            foreach (var item in arr)
            {
                if(item == 5)
                {
                    break;
                }
                ctr++;
            }
            int[] arr1 = new int[ctr];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
            return arr1;
        }
    }
}
