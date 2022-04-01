using System;

namespace A.Vasya_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5);
            for(int i = 0; i < 5; i++)
            {
                Console.Write("1 Burle amount: ");
                int burle1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2 Burle amount: ");
                int burle2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Output = {MinUnpayable(burle1, burle2)}");
            }
        }

        static int MinUnpayable(int burle1, int burle2)
        {
            int brl1 = 1;
            int brl2 = 2;
            if (burle1 == 0)
            {
                return 1;
            }
            return burle1 * brl1 + burle2 * brl2 + 1;
        }
    }
}
