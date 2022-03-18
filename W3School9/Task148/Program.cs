using System;
using System.Collections.Generic;

namespace Task148
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>() { "abc", "cdaef", "js", "php", "laravel", "lalalaa" };

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
                mylist1.Add(item.Replace("a", ""));
            }
            return mylist1;
        }
    }
}
