using System;

namespace Task60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1: ");
            string str1 = Console.ReadLine();
            Console.Write("Input 2: ");
            string str2 = Console.ReadLine();

            Console.WriteLine(NewStr(str1, str2));
        }

        static string NewStr(string str1, string str2)
        {
            return str1 + str2 + str2 + str1;
        }
    }
}
