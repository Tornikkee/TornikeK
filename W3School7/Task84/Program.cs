using System;

namespace Task84
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
            if((chars[0] == 'p' || chars[0] == 'P') && (chars[1] == 'y' || chars[1] == 'Y'))
            {
                string str = new string(chars);
                return str;
            }
            else if(chars[0] == 'p' || chars[0] == 'P')
            {
                string str = new string(input);
                return str.Remove(1, 1);
            }
            else if(chars[1] == 'y' || chars[1] == 'Y')
            {
                string str = new string(input);
                return str.Remove(0, 1);
            }
            else
            {
                return input.Remove(0, 2);
            }
        }
    }
}
