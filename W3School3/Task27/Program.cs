using System;

namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(CountA(input));
        }

        static int CountA(string input)
        {
            int counter = 0;

            for(int i = 0; i < input.Length - 1; i++)
            {
                if(input.Substring(i, 2) == "aa")
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
