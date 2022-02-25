using System;

namespace W3School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Sum = {0}", Sum(number1, number2));
        }


        static double Sum(double number1, double number2)
        {
            if (number1 == number2)
                return number1 * 6;
            else
                return number1 + number2;
        }
    }
}
