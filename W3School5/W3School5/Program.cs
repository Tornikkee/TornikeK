using System;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            Console.Write("Enter character to remove: ");
            char chr = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(RemoveChars(input, chr));
        }

        static string RemoveChars(string input, char chr)
        {
            for(int i = 1; i < input.Length - 1; i++)
            {
                if(input[i] == chr)
                {
                    input = input.Remove(i, 1);
                }
                
            }
            return input;
        }
    }
}
