using System;

namespace Task42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(input));
        }

        static bool Validate(int input)
        {
            if (input % 13 == 0 || (input - 1) % 13 == 0)
                return true;
            else
                return false;
        }
    }
}
