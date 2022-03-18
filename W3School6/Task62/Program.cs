using System;

namespace Task62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            if(input.Length < 2)
            {
                Console.WriteLine("Input lenght must be 2 or more than 2");
            }

            Console.WriteLine(NewStr(input));
        }

        static string NewStr(string input)
        {
            string str = "";
            try
            {
                str = input.Substring(input.Length - 2, 2);
            }
            catch
            {
                Console.WriteLine("");
            }
            return str + str + str;
        }
    }
}
