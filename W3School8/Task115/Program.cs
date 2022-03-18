using System;

namespace Task115
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 5, 6, 9, 10, 17 };
            int[] arr2 = new int[] { 1, 5, 5, 5, 10, 17 };
            int[] arr3 = new int[] { 1, 1, 5, 5, 5, 5 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
        }

        static bool Validate(int[] arr)
        {
            int ctr = 0;
            foreach (var item in arr)
            {
                if(item == 5)
                {
                    ctr++;
                }
            }
            if(ctr == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
