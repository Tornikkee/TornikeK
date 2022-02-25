using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(input1, input2));
        }

        static bool Validate(int input1, int input2)
        {
            if ((input1 > 100 && input1 < 200) || (input2 > 100 && input2 < 200))
                return true;
            else
                return false;
        }
    }
}
