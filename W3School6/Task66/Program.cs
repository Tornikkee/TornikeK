using System;

namespace Task66
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
            string small = "";
            string large = "";

            if(str1.Length > str2.Length)
            {
                large = str1;
                small = str2;
            }
            else
            {
                small = str1;
                large = str2;
            }

            return large + small + large;
        }
    }
}
