using System;

namespace Task49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 7, 9, 23, 7, 8, 3, 5 };
            int[] arr2 = new int[] { 1, 5, 32, 0, 45, 6, 18, 2 };
            int[] arr3 = new int[] { 9, 34, 76, 129, 307, 3, 6, 8 };
            int[] arr4 = new int[] { 1, 2, 0, 45, 67, 61, 56, 80, 78, 5 };

            Console.WriteLine(Validate(arr1, arr2));
            Console.WriteLine(Validate(arr1, arr3));
            Console.WriteLine(Validate(arr1, arr4));

        }

        static bool Validate(int[] arr1, int[] arr2)
        {
            if(arr1[0] == arr2[0] || arr1[arr1.Length - 1] == arr2[arr2.Length - 1])
            {
                return true;
            }
            return false;
        }
    }
}
