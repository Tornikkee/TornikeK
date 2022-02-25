using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(ReturnChecked(input));
        }

        static string ReturnChecked(string input)
        {
            char[] chars = input.ToCharArray();
            if(chars[1] == 'y' && chars[2] == 't')
            {
                return input.Remove(1, 2);
            }
            else
            {
                return input;
            }
        }
    }
}
