using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temp1: ");
            int temp1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Temp2: ");
            int temp2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(temp1, temp2));
        }

        static bool Validate(int temp1, int temp2)
        {
            if ((temp1 > 100 || temp1 < 0) && (temp2 > 100 || temp2 < 0))
                return true;
            else
                return false;
        }
    }
}
