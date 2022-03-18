using System;

namespace Task59
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
            int small = 0;
            int medium = 0;
            int large = 0;

            small = Min(num1, num2, num3);
            large = Max(num1, num2, num3);
            
            if(num1 > small && num1 < large)
            {
                medium = num1;
            }
            else if(num2 > small && num2 < large)
            {
                medium = num2;
            }
            else if(num3 > small && num3 < large)
            {
                medium = num3;
            }

            if(large - medium == 1 && medium - small == 1)
            {
                return true;
            }
            return false;
        }

        static int Min(int num1, int num2, int num3)
        {
            if(num1 < num2 && num1 < num3)
            {
                return num1;
            }
            else if(num2 < num1 && num2 < num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }

        static int Max(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
