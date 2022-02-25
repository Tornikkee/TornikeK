using System;

namespace Task30
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
            string str = "";
            for (int i = 0; i < input.Length; i++)
            {
                string str1 = input.Substring(i, 1);
                str += str1;
                for(int j = 0; j <= i; j++)
                {
                    str += input.Substring(j, 1);
                }
                if(i == input.Length - 1)
                {
                    str = str.Substring(0, str.Length - input.Length);
                }
            }
            return str;
        }
    }
}
