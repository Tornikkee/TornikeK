using System;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            Console.Write("Enter character that you want to remove: ");
            char chr = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(RemoveCharacters(input, chr));
        }

        static string RemoveCharacters(string input, char chr)
        {
            int i = 0;
            while (input.Contains(chr))
            {
                
                input = input.Remove(chr);
                i++
            }
            return input;
        }


    }
}
