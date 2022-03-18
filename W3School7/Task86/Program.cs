using System;

namespace Task86
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
            if(input.Substring(0,1) == "a" && input.Substring(input.Length - 1, 1) == "a")
            {
                return input.Substring(1, input.Length - 2);
            }
            else if(input.Substring(0, 1) == "a")
            {
                return input.Substring(1, input.Length - 1);
            }
            else if(input.Substring(input.Length - 1, 1) == "a")
            {
                return input.Substring(0, input.Length - 1);
            }
            else
            {
                return input;
            }
        }
    }
}
