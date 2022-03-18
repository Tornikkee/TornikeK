using System;

namespace Task73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(NewText(text, n));
        }

        static string NewText(string text, int n)
        {
            string str1 = "";
            string str2 = "";
            try
            {
                str1 = text.Substring(0, n);
                str2 = text.Substring(text.Length - n, n);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return str1 + str2;
        }
    }
}
