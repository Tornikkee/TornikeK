using System;

namespace Task12
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
            if (input.Contains("C#"))
                return true;
            else
                return false;
        }
    }
}
