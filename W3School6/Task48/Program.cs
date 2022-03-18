using System;

namespace Task48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(x, y, z));
        }

        static bool Validate(int x, int y, int z)
        {
            if (y > x && z > y)
                return true;
            return false;
        }
    }
}
