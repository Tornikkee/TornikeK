using System;

namespace Task57
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
            if(num1 >= 10 && num1 <= 20 && num1 != 13 && num1 != 17)
            {
                num1 = 0;
            }
            if(num2 >= 10 && num2 <= 20 && num2 != 13 && num2 != 17)
            {
                num2 = 0;
            }
            if(num3 >= 10 && num3 <= 20 && num3 != 13 && num3 != 17)
            {
                num3 = 0;
            }

            return num1 + num2 + num3;
        }
    }
}
