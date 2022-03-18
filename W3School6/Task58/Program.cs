using System;

namespace Task58
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ReturnVal(num1, num2));
        }

        static int ReturnVal(int num1, int num2)
        {
            if(num1 <= 13 && num2 <= 13)
            {
                if(13 - num1 < 13 - num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
            }
            else if(num1 <= 13 && num2 > 13)
            {
                return num1;
            }
            else if(num2 <= 13 && num1 > 13)
            {
                return num2;
            }
            else
            {
                return 0;
            }
        }
    }
}
