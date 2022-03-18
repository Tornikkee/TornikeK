using System;

namespace Task132
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 5, 3, 5, 4, 6, 9, 11 };
            int[] arr2 = new int[] { 3, 7, 8, 19, 2, 4, 18, 20, 13, 123, 120 };

            var arr3 = ShiftedArr(arr1);
            var arr4 = ShiftedArr(arr2);

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

        static int[] ShiftedArr(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    arr1[index] = arr[i];
                    index++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                    arr1[index] = arr[i];
                    index++;
                }
            }

            return arr1;
        }
    }
}
