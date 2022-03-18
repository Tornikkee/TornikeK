using System;

namespace Task51
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 34, 3, 5, 7, 8, 19, 86 };
            int[] arr2 = new int[] { 134, 203, 12, 5, 676, 67 };

            Console.WriteLine(Larger(arr1));
            Console.WriteLine(Larger(arr2));
        }

        static int Larger(int[] arr)
        {
            if(arr[0] > arr[arr.Length - 1])
            {
                return arr[0];
            }
            else if(arr[0] < arr[arr.Length - 1])
            {
                return arr[arr.Length - 1];
            }
            else
            {
                return arr[0];
            }
        }
    }
}
