using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(AddChars(input));
        }

        static string AddChars(string input)
        {
            char[] chars = input.ToCharArray();
            string str = chars[chars.Length - 1] + input + chars[chars.Length - 1];

            return str;
        }
    }
}
