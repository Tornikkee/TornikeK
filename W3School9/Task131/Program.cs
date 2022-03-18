using System;

namespace Task131
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 };
            int[] arr2 = new int[] { 12, 5, 5, 48, 7, 5, 125, 15, 67, 5 };

            int[] arr3 = ShiftedArr(arr1);
            int[] arr4 = ShiftedArr(arr2);

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

        static int[] ShiftedArr(int [] arr)
        {
            int[] arr1 = new int[arr.Length];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 5)
                {
                    arr1[index] = arr[i];
                    index++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 5)
                {
                    arr[i] = 0;
                    arr1[index] = arr[i];
                    index++;
                }
            }

            return arr1;
        }
    }
}
