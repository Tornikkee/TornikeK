using System;

namespace Task105
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 300, 5, 9, 19, 21, 47, 87 };

            var arr1 = SwapElements(arr);

            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
        }

        static int[] SwapElements(int[] arr)
        {
            int temp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = temp;

            return arr;
        }
    }
}
