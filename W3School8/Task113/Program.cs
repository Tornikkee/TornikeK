using System;

namespace Task113
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 5, 6, 9, 10, 17 };
            int[] arr2 = new int[] { 1, 5, 5, 9, 10, 17 };
            int[] arr3 = new int[] { 1, 5, 5, 9, 10, 17, 5, 5 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
        }

        static bool Validate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(i < arr.Length - 1)
                {
                    if(arr[i] == 5 && arr[i + 1] == 5)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
