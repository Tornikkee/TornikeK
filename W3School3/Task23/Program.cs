using System;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(num1, num2));
        }

        static bool Validate(int num1, int num2)
        {
            if (num1 % 10 == num2 % 10)
                return true;
            else
                return false;
        }
    }
}
