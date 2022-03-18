using System;

namespace Task56
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
            if(num1 == 13)
            {
                return 0;
            }
            else if(num2 == 13)
            {
                return num1;
            }
            else if(num3 == 13)
            {
                return num1 + num2;
            }
            return num1 + num2 + num3;
        }
    }
}
