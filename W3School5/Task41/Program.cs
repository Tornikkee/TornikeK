using System;

namespace Task41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(num1, num2));
        }

        static bool Validate(int num1, int num2)
        {
            if (num1 + num2 == 5)
                return true;
            else if (num1 - num2 == 5 || num2 - num1 == 5)
                return true;
            else if (num1 == 5 || num2 == 5)
                return true;
            else
                return false;
        }
    }
}
