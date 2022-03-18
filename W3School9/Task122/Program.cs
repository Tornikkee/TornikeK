using System;

namespace Task122
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 5, 1, 3, 7 };
            int[] arr2 = new int[] { 1, 2, 3, 4 };
            int[] arr3 = new int[] { 3, 3, 5, 5, 5, 5 };
            int[] arr4 = new int[] { 2, 4, 5, 6 };

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
                    if(arr[i] % 2 == 0 && arr[i + 1] % 2 == 0 || arr[i] % 2 != 0 && arr[i + 1] % 2 != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
