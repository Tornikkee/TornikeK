using System;

namespace Task61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1: ");
            string str1 = Console.ReadLine();
            Console.Write("Input 2: ");
            string str2 = Console.ReadLine();
            if(str2.Length != 4)
            {
                Console.WriteLine("Input 2 string's length must be equal to 4");
            }

            Console.WriteLine(NewStr(str1, str2));
        }

        static string NewStr(string str1, string str2)
        {
            string str21 = str2.Substring(0, 2);
            string str22 = str2.Substring(2, 2);

            return str21 + str1 + str22;
        }
    }
}
