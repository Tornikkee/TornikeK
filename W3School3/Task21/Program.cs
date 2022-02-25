using System;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ReturnLargerInRange(num1, num2));
        }

        static int ReturnLargerInRange(int num1, int num2)
        {
            var validate = Validate(num1, num2);
            if (validate == true && num1 > num2)
                return num1;
            else if (validate == true && num2 > num1)
                return num2;
            else if (validate == true && num1 == num2)
                return num1;
            else
                return 0;
        }

        static bool Validate(int num1, int num2)
        {
            var firstVal = num1 >= 20 && num1 <= 30;
            var secondVal = num2 >= 20 && num2 <= 30;
            if (firstVal == true && secondVal == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
