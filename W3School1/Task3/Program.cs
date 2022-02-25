using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First integer: ");
            int fI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second integer: ");
            int sI = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Validate(fI, sI));
        }

        static bool Validate(int num1, int num2)
        {
            if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
                return true;
            else
                return false;
        }
    }
}
