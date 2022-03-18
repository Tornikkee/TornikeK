using System;

namespace Task83
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
            if(input.Length < 2)
            {
                return input + input + input;
            }
            return input.Substring(0, 2) + input.Substring(0, 2) + input.Substring(0, 2);
        }
    }
}
