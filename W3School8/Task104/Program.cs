using System;

namespace Task104
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 12, 21, 22, 80, 99 };
            int[] arr2 = new int[] { 300, 5, 9, 19, 21, 47, 87 };

            var arr3 = NewArr(arr1, arr2);

            foreach (var item in arr3)
            {
                Console.Write(item + " ");
            }
        }

        static int[] NewArr(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length + i] = arr2[i];
            }

            return arr3;
        }
    }
}
