using System;

namespace Task129
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 5, 7, 9, 11 };
            int[] arr2 = new int[] { 1, 3, 700, 5, 18, 14, 23, 400, 59 };

            var arr3 = FilteredArr(arr1);
            var arr4 = FilteredArr(arr2);

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

        static int[] FilteredArr(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 5)
                {
                    index = i;
                    break;
                }
            }
            int[] arr1 = new int[arr.Length - index - 1];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[index + 1 + i];
            }
            return arr1;
        }
    }
}
