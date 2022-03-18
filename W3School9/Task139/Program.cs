using System;

namespace Task139
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(num));
            Console.WriteLine(Validate2(num));
        }

        static bool Validate(int num)
        {
            string numstr = num.ToString();
            if (numstr.Contains('2'))
            {
                return true;
            }
            return false;
        }

        static bool Validate2(int num)
        {
            while(num > 0)
            {
                if(num % 10 == 2)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
    }
}
