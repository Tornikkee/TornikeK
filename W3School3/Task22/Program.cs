using System;

namespace Task22
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
            char[] chars = input.ToCharArray();
            if (chars[2] == 'z' || chars[3] == 'z' || chars[4] == 'z')
                return true;
            else
                return false;
        }
    }
}
