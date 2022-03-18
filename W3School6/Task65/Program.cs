using System;

namespace Task65
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
            string str = input.Substring(1, input.Length - 2);

            return str;
        }
    }
}
