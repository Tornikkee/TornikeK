using System;

namespace Task50
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 8 };

            Rotate(arr);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static int[] Rotate(int[] arr)
        {
            var e0 = arr[0];
            var e1 = arr[1];
            var e2 = arr[2];

            arr[0] = e1;
            arr[1] = e2;
            arr[2] = e0;

            return arr;
        }
    }
}
