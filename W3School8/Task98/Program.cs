using System;

namespace Task98
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 15, 20 };
            int[] arr2 = new int[] { 12, 307 };
            int[] arr3 = new int[] { 15, 0 };
            int[] arr4 = new int[] { 124, 20 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
            Console.WriteLine(Validate(arr4));
        }

        static bool Validate(int[] arr)
        {
            if((arr[0] != 15 && arr[0] != 20) && (arr[1] != 15 && arr[1] != 20))
            {
                return true;
            }
            return false;
        }
    }
}
