using System;

namespace Task75
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
            if(input.Length % 2 == 0)
            {
                string str1 = input.Substring(input.Length / 2 - 2, 3);
                return str1;
            }
            return input.Substring(((input.Length - 1) / 2) - 1, 3);
        }
    }
}
