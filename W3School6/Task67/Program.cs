using System;

namespace Task67
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
            string newstr1 = str1.Substring(1, str1.Length - 1);
            string newstr2 = str2.Substring(1, str2.Length - 1);

            return newstr1 + newstr2;
        }
    }
}
