using System;

namespace Task71
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
                return "String length must be even number";
            }

            string str = "";

            try
            {
                str = input.Substring((input.Length / 2) - 1, 2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return str;
        }
    }
}
