using System;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(ReturnDifferent(input));
        }
        
        static string ReturnDifferent(string input)
        {
            char[] chars = input.ToCharArray();
            char[] chars1 = new char[input.Length / 2];

            chars1[0] += chars[0];
            for(int i = 1; i < input.Length - 1; i++)
            {
                if(i % 2 == 0)
                {
                    chars1[i / 2] += chars[i];
                }
            }
            string str = new string(chars1);

            return str;
        }

        
    }
}
