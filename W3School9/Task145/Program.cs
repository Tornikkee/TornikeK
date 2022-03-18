using System;
using System.Collections.Generic;

namespace Task145
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>() { 1, 2, 3, 4 };

            var mylist1 = NewList(mylist);
            foreach (var item in mylist1)
            {
                Console.Write(item + " ");
            }
        }

        static List<int> NewList(List<int> mylist)
        {
            List<int> mylist1 = new List<int>();
            foreach (var item in mylist)
            {
                mylist1.Add((item + 2) * 5);
            }
            return mylist1;
        }
    }
}
