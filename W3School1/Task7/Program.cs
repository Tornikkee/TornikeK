using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(Exchange(input));
        }

        static string Exchange(string str)
        {
            char[] charArray = str.ToCharArray();
            
            if(charArray.Length > 1)
            {
                var c = charArray[0];
                charArray[0] = charArray[charArray.Length - 1];
                charArray[charArray.Length - 1] = c;
            }
            string str1 = new string(charArray);

            return str1;
        }
    }
}
