using System;

namespace Task64
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
            if(input.Length % 2 != 0)
            {
                string str = input.Substring(0, (input.Length - 1) / 2);
                return str;
            }
            string str1 = input.Substring(0, input.Length / 2);
            return str1;
        }
    }
}
