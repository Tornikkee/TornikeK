using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to find difference: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Difference = {0}", Difference(n));
        }

        static double Difference(double n)
        {
            const double number = 51;
            if (number < n)
                return (n - number) * 3;
            else
                return number - n;
        }
    }
}
