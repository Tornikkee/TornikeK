using System;

namespace Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();
            Console.Write("Integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number > 0)
            {
                Console.WriteLine(First3(text, number));
            }
            else
            {
                Console.WriteLine("Integer must be more than 0");
            }
        }

        static string First3(string text, int number)
        {
            char[] chars = text.ToCharArray();
            if(text.Length < 3)
            {
                string str2 = "";
                for(int i = 0; i < number; i++)
                {
                    str2 += text;
                }
                return str2;
            }
            else
            {
                char[] charsEdited = new char[3];
                charsEdited[0] = chars[0];
                charsEdited[1] = chars[1];
                charsEdited[2] = chars[2];

                string str = new string(charsEdited);
                string str1 = "";

                for (int i = 0; i < number; i++)
                {
                    str1 += str;
                }

                return str1;
            }
            
        }
    }
}
