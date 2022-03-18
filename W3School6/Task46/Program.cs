using System;

namespace Task46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(Validate(input));
        }

        static string Validate(string input)
        {
            char[] chars = input.ToCharArray();
            if ((chars[0] == 'F' || chars[0] == 'f') && (chars[chars.Length - 1] == 'B' || chars[chars.Length - 1] == 'b'))
                return "FizzBuzz";
            if (chars[0] == 'F' || chars[0] == 'f')
                return "Fizz";
            if (chars[chars.Length - 1] == 'B' || chars[chars.Length - 1] == 'b')
                return "Buzz";
            return input;
        }
    }
}
