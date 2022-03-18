using System;

namespace Task82
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
            if (str1.Length > str2.Length)
            {
                int n = str1.Length - str2.Length;
                return str1.Remove(0, n) + str2;
            }
            else if (str1.Length < str2.Length)
            {
                int n = str2.Length - str1.Length;
                return str1 + str2.Remove(0, n);
            }
            else
            {
                return str1 + str2;
            }
        }
    }
}
