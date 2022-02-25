using System;

namespace Task20
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
            if (num1 >= 40 && num1 <= 50 && num2 >= 40 && num2 <= 50)
                return true;
            else if (num1 >= 50 && num1 <= 60 && num2 >= 50 && num2 <= 60)
                return true;
            else
                return false;
        }
    }
}
