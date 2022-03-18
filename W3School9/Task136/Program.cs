using System;

namespace Task136
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = new string[] { "a", "b", "bb", "c", "ccc" };
            Console.Write("Enter number: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CountStrings(arr1, length));
        }

        static int CountStrings(string[] arr, int length)
        {
            int ctr = 0;
            foreach (var item in arr)
            {
                if(item.Length == length)
                {
                    ctr++;
                }
            }
            return ctr;
        }
    }
}
