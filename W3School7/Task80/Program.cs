using System;

namespace Task80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            Console.WriteLine(NewStr(input));
        }

        static string NewStr(string input)
        {
            try
            {
                if (input.Substring(0, 3) == "abc")
                {
                    return "abc";
                }
                else if (input.Substring(0, 3) == "xyz")
                {
                    return "xyz";
                }
                else
                {
                    return "";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
    }
}
