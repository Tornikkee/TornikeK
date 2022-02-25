using System;

namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = new int[] { 1, 2, 3 };
            int[] arr1 = new int[] { 98, 45, 100, 5, 3, 1, 2, 0, 31, 1, 2, 3, 5, 7, 19, 22 };
            int[] arr2 = new int[] { 12, 3, 1, 2, 4, 7, 7, 8, 19, 201, 1, 2, 3 };
            int[] arr3 = new int[] { 1, 7, 8, 0, 10, 15, 17, 50, 132, 701 };

            Console.WriteLine(Validate(seq, arr3));
        }

        static bool Validate(int[] seq, params int[] array)
        {
            for(int i = 0; i < array.Length - 2; i++)
            {
                if(seq[0] == array[i] && seq[1] == array[i + 1] && seq[2] == array[i + 2])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
