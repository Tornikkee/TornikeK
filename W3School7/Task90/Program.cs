using System;

namespace Task90
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 15, 23, 25, 19, 0 };
            int[] arr2 = new int[] { 7, 3, 45, 76, 20, 0, 20, 10 };
            int[] arr3 = new int[] { 10, 2, 3, 6, 7, 10 };
            int[] arr4 = new int[] { 1, 3, 4, 5, 7, 8, 9, 17 };

            Console.WriteLine(Validate(arr1,arr2));
            Console.WriteLine(Validate(arr3, arr4));
            Console.WriteLine(Validate(arr1, arr3));
            Console.WriteLine(Validate(arr2, arr4));
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
