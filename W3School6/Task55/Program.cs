using System;

namespace Task55
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

            Console.WriteLine(Sum(num1, num2, num3));
        }

        static int Sum(int num1, int num2, int num3)
        {
            if (num1 == num2)
            {
                return num3;
            }
            else if(num1 == num3)
            {
                return num2;
            }
            else if(num2 == num3)
            {
                return num1;
            }
            return num1 + num2 + num3;
        }
    }
}
