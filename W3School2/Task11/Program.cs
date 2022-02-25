using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(AddChars(input));
        }

        static string AddChars(string input)
        {
            char[] chars = input.ToCharArray();
            char[] charsSaved = new char[3];
            if(chars.Length < 3)
            {
                for(int i = 0; i < chars.Length; i++)
                {
                    charsSaved[i] += chars[i];
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    charsSaved[i] += chars[i];
                }
            }
            
            string str = new string(charsSaved);

            string str1 = str + input + str;

            return str1;
            
        }
    }
}
