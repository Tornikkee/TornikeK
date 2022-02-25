﻿using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(input));
        }

        static bool Validate(int input)
        {
            if (input % 3 == 0 || input % 7 == 0)
                return true;
            else
                return false;
        }
    }
}
