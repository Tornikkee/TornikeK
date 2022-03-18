using System;
using System.Collections.Generic;

namespace Task143
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>() { "1", "2", "3", "4" };

            var mylist1 = NewList(mylist);
            foreach (var item in mylist1)
            {
                Console.Write(item + " ");
            }
        }

        static List<string> NewList(List<string> mylist)
        {
            List<string> mylist1 = new List<string>();
            foreach (var item in mylist)
            {
                mylist1.Add("#" + item);
            }
            return mylist1;
        }
    }
}
