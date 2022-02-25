using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: {0}", ValidateNumber(n));
        }

        static bool ValidateNumber(int number)
        {
            if ((number >= 90 && number <= 110) || (number >= 190 && number <= 210))
                return true;
            else
                return false;
        }
    }
}
