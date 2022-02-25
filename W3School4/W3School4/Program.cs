using System;

namespace Task28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(Validate(input));
        }

        static bool Validate(string input)
        {
            char[] chars = input.ToCharArray();
            int counter = 0;
            

            for(int i = 0; i < input.Length - 1; i++)
            {
                if(chars[i] == 'a')
                {
                    counter++;
                }
                if (counter < 2 && input.Substring(i, 2) == "aa")
                {
                    return true;
                }
                
            }

            return false;
        }
    }
}
