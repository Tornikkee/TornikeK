using System;

namespace Task72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(Validate(input));
        }

        static bool Validate(string input)
        {
            string str = "on";
            bool c = false;
            try
            {
                c = input.ToUpper().Substring(input.Length - 2, 2) == str.ToUpper();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (c == true)
            {
                return true;
            }
            return false;
        }
    }
}
