using System;
using System.Collections.Generic;

namespace Task150
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>() { 10, 22, 35, 47, 53, 67 };

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
                if(item % 10 != 7)
                {
                    mylist1.Add(item);
                }
            }
            return mylist1;
        }
    }
}
