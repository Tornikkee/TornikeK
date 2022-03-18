using System;

namespace Task79
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
                return input;
            }

            string str1 = "";
            string str2 = "";
            string str3 = "";

            str1 = input.Substring(0, input.Length - 2);
            str2 = input.Substring(input.Length - 2, 1);
            str3 = input.Substring(input.Length - 1, 1);

            return str1 + str3 + str2;

        }
    }
}
