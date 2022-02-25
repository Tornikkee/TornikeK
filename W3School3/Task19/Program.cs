using System;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Nearest(num1, num2));
        }

        static int Nearest(int num1, int num2)
        {
            const int num3 = 100;

            if (num3 - num1 < num3 - num2)
                return num1;
            else if (num1 == num2)
                return 0;
            else
                return num2;
        }
    }
}
