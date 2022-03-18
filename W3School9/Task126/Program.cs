using System;

namespace Task126
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 5, 3, 7 };
            int[] arr2 = new int[] { 3, 7, 5, 5, 3, 7 };
            int[] arr3 = new int[] { 3, 7, 5, 5, 6, 7, 5 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
        }

        static bool Validate(int[] arr)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if(arr[i] < arr[i + 1] && arr[i + 1] < arr[i + 2])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
