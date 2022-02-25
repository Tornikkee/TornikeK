using System;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(ToUpperLast3(input));
        }

        static string ToUpperLast3(string input)
        {
            char[] chars = input.ToCharArray();
            char[] lastThree = new char[3];
            lastThree[0] = chars[chars.Length - 3];
            lastThree[1] = chars[chars.Length - 2];
            lastThree[2] = chars[chars.Length - 1];
            string str = new string(lastThree);

            return input.Remove(input.Length - 3, 3) + str.ToUpper();
        }
    }
}
