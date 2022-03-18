using System;

namespace Task69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(NewStr(input));
        }

        static string NewStr(string input)
        {
            string str1 = input.Substring(0, input.Length - 2);
            string str2 = input.Substring(input.Length - 2, 2);

            return str2 + str1;
        }
    }
}
