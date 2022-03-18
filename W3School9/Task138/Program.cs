using System;

namespace Task138
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "a", "aaa", "b", "bbb", "c", "ccc" };
            Console.Write("Enter length of array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            var arr1 = NewArr(arr, length);
            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
        }

        static string[] NewArr(string[] arr, int length)
        {
            int ctr = 0;
            foreach (var item in arr)
            {
                if(item.Length == length)
                {
                    ctr++;
                }
            }
            string[] arr1 = new string[ctr];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Length == length)
                {
                    arr1[index] = arr[i];
                    index++;
                }
            }
            return arr1;
        }
    }
}
