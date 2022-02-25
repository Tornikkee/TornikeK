using System;

namespace Task35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Input 2: ");
            string input2 = Console.ReadLine();

            Console.WriteLine(CompareSubstrings(input1, input2));
        }

        static int CompareSubstrings(string input1, string input2)
        {
            int counter = 0;
            
            for(int i = 0; i < input1.Length - 1; i++)
            {
                string str = input1.Substring(i, 2);
                for(int j = 0; j < input2.Length - 1; j++)
                {
                    string str1 = input2.Substring(j, 2);
                    if (str == str1)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
