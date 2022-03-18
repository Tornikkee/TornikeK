using System;

namespace Task137
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "a", "b", "bb", "c", "ccc" };
            Console.Write("Enter length of new array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] arr1 = new string[length];
            try
            {
                arr1 = NewArr(arr, length);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
        }

        static string[] NewArr(string[] arr, int length)
        {
            string[] arr1 = new string[length];

            for (int i = 0; i < length; i++)
            {
                arr1[i] = arr[i];
            }
            return arr1;
        }
    }
}
