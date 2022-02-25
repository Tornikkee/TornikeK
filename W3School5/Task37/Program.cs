using System;

namespace Task37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(NewString(input));
        }

        static string NewString(string input)
        {
            string str = "";
            for(int i = 0; i < input.Length; i++)
            {
                if(i == 0 || i == 1 || i % 4 == 0 || (i - 1) % 4 == 0)
                {
                    str += input[i];
                }
            }
            return str;
        }
    }
}
