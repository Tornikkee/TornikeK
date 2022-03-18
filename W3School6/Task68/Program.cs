using System;

namespace Task68
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
            string str1 = "";
            string str2 = "";
            try
            {
                str1 = input.Substring(0, 2);
                str2 = input.Substring(2, input.Length - 2);
            }
            catch
            {
                Console.WriteLine("Input lenth must be 2 or more...");
            }

            return str2 + str1;
        }
    }
}
