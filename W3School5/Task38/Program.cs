using System;

namespace Task38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 5, 10, 5, 5, 32, 196, 5, 6 };
            int[] arr2 = new int[] { 5, 6, 1, 3, 4, 17 };

            Console.WriteLine(CountInArray(arr1));
            Console.WriteLine(CountInArray(arr2));
        }

        static int CountInArray(params int[] array)
        {
            int counter = 0;
            for(int i = 0; i < array.Length - 1; i++)
            {
                if((array[i] == 5 && array[i + 1] == 5) || (array[i] == 5 && array[i + 1] == 6))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
