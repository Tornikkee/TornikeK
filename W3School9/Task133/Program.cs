using System;

namespace Task133
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 5, 1, 5, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4 };
            int[] arr3 = new int[] { 3, 3, 5, 5, 5, 5 };
            int[] arr4 = new int[] { 1, 5, 5, 7, 8, 10 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
            Console.WriteLine(Validate(arr4));
        }

        static bool Validate(int[] arr)
        {
            int validator = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] >= arr[i - 1])
                {
                    validator++;
                }
            }

            return validator == arr.Length - 1;
        }
    }
}
