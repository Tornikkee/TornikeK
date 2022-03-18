using System;

namespace Task47
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
            return num1 + num2 == num3;
        }
    }
}
