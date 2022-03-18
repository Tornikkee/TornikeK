using System;

namespace Task114
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 5, 6, 9, 10, 17 };
            int[] arr2 = new int[] { 1, 4, 7, 9, 10, 17 };
            int[] arr3 = new int[] { 1, 1, 2, 9, 10, 17 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
        }

        static bool Validate(int[] arr)
        {
            foreach (var item in arr)
            {
                if(item == 5 || item == 7)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
