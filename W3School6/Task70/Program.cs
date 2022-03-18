using System;

namespace Task70
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
            string str = "";
            try
            {
                str = input.Substring(1, input.Length - 2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            return str;
        }
    }
}
