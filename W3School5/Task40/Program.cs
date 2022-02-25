using System;

namespace Task40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sum(num1, num2));
        }

        static int Sum(int num1, int num2)
        {
            if(num1 + num2 >= 10 && num1 + num2 <= 20)
            {
                return 30;
            }
            return num1 + num2;
        }
    }
}
