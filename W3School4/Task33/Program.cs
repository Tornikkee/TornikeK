using System;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[] { 1, 9, 23, 45, 37, 98 };

            Console.WriteLine(Validate(input, arr));
        }

        static bool Validate(int input, params int[] arr)
        {
            for(int i = 0; i < 4; i++)
            {
                if(arr[i] == input)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
