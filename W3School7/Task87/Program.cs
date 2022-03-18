using System;

namespace Task87
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
            char[] chars = input.ToCharArray();
            if(chars[0] == 'a' && chars[1] == 'a')
            {
                return input.Substring(2, input.Length - 2);
            }
            else if(chars[0] == 'a')
            {
                return input.Substring(1, input.Length - 1);
            }
            else if(chars[1] == 'a')
            {
                return input.Substring(0, 1) + input.Substring(2, input.Length - 2);
            }
            return input;
        }
    }
}
