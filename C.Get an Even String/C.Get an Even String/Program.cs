using System;
using System.Collections.Generic;

namespace C.Get_an_Even_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            string str = RemoveDoubles(input);
            int result = MustRemove(str);
            Console.WriteLine(result);
            Console.WriteLine(str);
        }

        static int MustRemove(string str)
        {
            char[] chars = str.ToCharArray();
            int ctr = 0;
            int ctr1 = 0;
            foreach (var item in chars)
            {
                if(item != ' ')
                {
                    ctr1++;
                }
            }
            foreach (var item in chars)
            {
                if(item != ' ')
                {
                    ctr--;
                }
            }

            for (int i = 0; i < chars.Length; i++)
            {
                if(chars[i] != ' ')
                {
                    for (int j = 0; j < chars.Length; j++)
                    {
                        if(chars[j] != ' ')
                        {
                            if(chars[i] == chars[j])
                            {
                                ctr++;
                            }
                        }
                    }
                }
            }
            return ctr1 - (ctr / 2);
        }

        static string RemoveDoubles(string input)
        {
            char[] chars = input.ToCharArray();

            if(chars.Length % 2 == 0)
            {
                for (int i = 0; i < chars.Length; i+=2)
                {
                    if(chars[i] == chars[i + 1])
                    {
                        chars[i] = ' ';
                        chars[i + 1] = ' ';
                    }
                }
            }
            else
            {
                if(chars[chars.Length - 1] == chars[chars.Length - 2])
                {
                    chars[chars.Length - 1] = ' ';
                    chars[chars.Length - 2] = ' ';
                }
                for (int i = 0; i < chars.Length - 1; i++)
                {
                    if (chars[i] == chars[i + 1])
                    {
                        chars[i] = ' ';
                        chars[i + 1] = ' ';
                    }
                }
            }
            string str = new string(chars);
            return str;
        }   
    }
}
