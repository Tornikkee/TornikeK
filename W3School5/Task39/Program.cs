using System;

namespace Task39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, 5, 7, 7, 7, 19, 21 };
            int[] arr2 = new int[] { 102, 37, 23, 45, 1, 0, 9, 18 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
        }

        static bool Validate(params int[] array)
        {
            for(int i = 0; i < array.Length - 2; i++)
            {
                if(array[i] == array[i + 1] && array[i] == array[i + 2])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
