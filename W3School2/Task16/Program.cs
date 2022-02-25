using System;

namespace Task16
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
            var firstVal = num1 >= 20 && num1 <= 50;
            var secondVal = num2 <= 20 || num2 >= 50;
            var thirdVal = num2 >= 20 && num2 <= 50;
            var fourthVal = num1 <= 20 || num1 >= 50;

            if (firstVal == true && secondVal == true)
                return true;
            else if (thirdVal == true && fourthVal == true)
                return true;
            else
                return false;
        }
    }
}
