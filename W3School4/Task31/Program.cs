using System;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(ReturnSubstr(input));
        }

        static int ReturnSubstr(string input)
        {
            int counter = 0;
            if (input.Substring(0, 2) == input.Substring(input.Length - 2, 2))
            {
                counter++;
                for(int i = 2; i <= input.Length - 4; i++)
                {
                    if(input.Substring(i, 2) == input.Substring(0, 2))
                    {
                        counter++;
                    }
                }
                
            }
            return counter;
        }
    }
}
