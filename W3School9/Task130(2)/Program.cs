using System;

namespace Task130_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 };
            int[] arr2 = new int[] { 9, 7, 0, 0, 100, 0, 45, 0, 23, 78, 0 };

            ShiftedArr(arr1);
            ShiftedArr(arr2);

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

        static int[] ShiftedArr(int[] arr)
        {
            int index = 0;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    temp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = temp;
                    index++;
                }
            }
            return arr;
        }
    }
}
