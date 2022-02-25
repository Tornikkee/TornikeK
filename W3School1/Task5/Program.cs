using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            var check = ContainsIf(input.ToUpper());
            if(check == true)
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(AddIf(input));
            }

        }

        static bool ContainsIf(string value)
        {
            const string valueElement = "if";
            bool c = value.Contains(valueElement.ToUpper());
            return c;
        }

        static string AddIf(string value)
        {
            return "if " + value;
        }
    }
}
