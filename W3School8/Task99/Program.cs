using System;

namespace Task99
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 3, 18, 21, 19, 200 };

            var arr1 = NewArr(arr);
            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
        }

        static int[] NewArr(int[] arr)
        {
            int[] arr1 = new int[arr.Length * 2];
            arr1[0] = arr[0];

            return arr1;
        }
    }
}
