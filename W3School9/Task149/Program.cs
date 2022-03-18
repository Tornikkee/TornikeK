using System;
using System.Collections.Generic;

namespace Task149
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>() { 0, -2, 1, 2, 3, 5, 4, 7, 8 };

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
                if(item < 4)
                {
                    mylist1.Add(item);
                }
            }
            return mylist1;
        }
    }
}
