using System;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();
            Console.Write("Integer: ");
            int integer = Convert.ToInt32(Console.ReadLine());
            if(integer > 0)
            {
                Console.WriteLine(MultiString(text, integer));
            }
            else
            {
                Console.WriteLine("Integer must be more than zero");
            }
        }

        static string MultiString(string text, int integer)
        {
            string str = "";
            for(int i = 0; i < integer; i++)
            {
                str += text;
            }
            return str;
        }
    }
}
