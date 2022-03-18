using System;

namespace Task130_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 };
            int[] arr2 = new int[] { 9, 7, 0, 0, 100, 0, 45, 0, 23, 78, 0 };

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
            int index = 0;
            int[] arr1 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    arr1[index] = arr[i];
                    index++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    arr1[index] = arr[i];
                    index++;
                }
            }

            return arr1;
        }
    }
}
