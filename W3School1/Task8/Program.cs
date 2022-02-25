using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(Copy(input));
        }

        static string Copy(string input)
        {
            char[] chars = input.ToCharArray();

            char[] charsFiltered = new char[2];

            charsFiltered[0] = chars[0];
            charsFiltered[1] = chars[1];

            string str1 = new string(charsFiltered);
            string output = "";

            for(int i = 0; i < 4; i++)
            {
                output += str1;
            }

            return output;
        }

        
    }
}
