using System;

namespace Task6
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Input: ");
        //    string input = Console.ReadLine();
        //    Console.Write("Index: ");
        //    int index = Convert.ToInt32(Console.ReadLine());
        //    RemoveChar(input, index);
        //}

        //static void RemoveChar(string str, int index)
        //{
        //    char[] charArray = str.ToCharArray();
            
        //    for(int i = 0; i < charArray.Length; i++)
        //    {
        //        if(i != index)
        //        {
        //            Console.Write(charArray[i]);
        //        }
        //    }
        //}

        static void Main()
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            Console.Write("Index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(RemoveChar(input, index));
        }

        static string RemoveChar(string str, int index)
        {
            var c = str.Remove(index, 1);
            return c;
        }


    }
}
