using System;
using System.Collections.Generic;

namespace Task146
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>() { 10, 22, 35, 41 };

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
                mylist1.Add(item % 10);
            }
            return mylist1;
        }
    }
}
