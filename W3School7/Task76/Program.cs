using System;

namespace Task76
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
            if(input.Length == 1)
            {
                string str = input + "#";
                return str;
            }
            else if(input.Length == 0)
            {
                string str = "##";
                return str;
            }
            return input.Substring(0, 2);
        }
    }
}
