using System;

namespace Task63
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
            if(input.Length > 2)
            {
                string str = input.Substring(0, 2);
                return str;
            }
            return input;
        }
    }
}
