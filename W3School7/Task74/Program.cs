using System;

namespace Task74
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string str = Console.ReadLine();
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(NewStr(str, n));
        }

        static string NewStr(string str, int n)
        {
            string str1 = "";
            try
            {
                str1 = str.Substring(n, 2);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

            return str1;
        }
    }
}
