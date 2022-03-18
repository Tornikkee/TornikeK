using System;

namespace Task81
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(Validate(input));
        }

        static bool Validate(string input)
        {
            if (input.Substring(0, 2) == input.Substring(input.Length - 2, 2))
            {
                return true;
            }

            return false;
        }
    }
}
