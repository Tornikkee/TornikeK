using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(num1, num2, num3));
        }

        static bool Validate(int num1, int num2, int num3)
        {
            if((num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
