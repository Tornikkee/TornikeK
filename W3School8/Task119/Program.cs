using System;

namespace Task119
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 5, 5, 5, 5 };
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
            for (int i = 0; i < arr.Length; i++)
            {
                if(i < arr.Length - 1)
                {
                    if(arr[i] == 3 && arr[i + 1] == 3 || arr[i] == 5 && arr[i+1] == 5)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
