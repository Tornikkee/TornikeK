using System;

namespace Task85
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
            try
            {
                if (input.Substring(0, 2) == (input.Substring(input.Length - 2, 2)))
                {
                    return input.Substring(2, input.Length - 2);
                }
                else return input;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
