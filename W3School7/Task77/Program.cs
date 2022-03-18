using System;

namespace Task77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Input 2: ");
            string input2 = Console.ReadLine();

            Console.WriteLine(NewStr(input1, input2));
        }

        static string NewStr(string input1, string input2)
        {
            if(input1.Length == 0)
            {
                input1 = "#";
            }
            if(input2.Length == 0)
            {
                input2 = "#";
            }

            string str1 = input1.Substring(0, 1);
            string str2 = input2.Substring(input2.Length - 1, 1);

            return str1 + str2;
        }
    }
}
