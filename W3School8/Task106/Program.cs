using System;

namespace Task106
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 300, 5, 9, 19, 21, 47, 87 };
            int[] arr2 = new int[] { 107, 15, 23, 45, 67, 89, 10, 2 };

            var arr3 = NewArr(arr1);
            var arr4 = NewArr(arr2);

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

        static int[] NewArr(int[] arr)
        {
            if(arr.Length % 2 == 0)
            {
                int[] arr1 = new int[3];
                arr1[0] = arr[arr.Length / 2 - 2];
                arr1[1] = arr[arr.Length / 2 - 1];
                arr1[2] = arr[arr.Length / 2];

                return arr1;
            }
            else
            {
                int[] arr2 = new int[3];
                arr2[0] = arr[(arr.Length - 1) / 2 - 1];
                arr2[1] = arr[(arr.Length - 1) / 2];
                arr2[2] = arr[(arr.Length - 1) / 2 + 1];

                return arr2;
            }
        }
    }
}
