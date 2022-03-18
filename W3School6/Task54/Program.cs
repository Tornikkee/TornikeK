using System;

namespace Task54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sum(x, y));
        }

        static int Sum(int x, int y)
        {
            int sum = x + y;
            if(x.ToString().Length != sum.ToString().Length)
            {
                return x;
            }

            return x + y;
        }
    }
}
