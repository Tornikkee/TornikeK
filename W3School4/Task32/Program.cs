using System;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[] { 10, 47, 123, 31, 201, 2, 0, 15, 5, 3, 20, 21, 43, 22, 99 };

            Console.WriteLine(Validate(input, array));
        }

        static bool Validate(int input, params int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(input == array[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
