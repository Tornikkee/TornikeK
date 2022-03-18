using System;

namespace Task116
{
    class Program
    {
        static void Main(string[] args)
        {
            //if amount of 3 is greater than 5 program returns true

            int[] arr1 = new int[] { 1, 5, 6, 9, 3, 3 };
            int[] arr2 = new int[] { 1, 5, 5, 5, 10, 17 };
            int[] arr3 = new int[] { 1, 3, 3, 5, 5, 5 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
        }

        static bool Validate(int[] arr)
        {
            int ctr3 = 0;
            int ctr5 = 0;

            foreach (var item in arr)
            {
                if(item == 3)
                {
                    ctr3++;
                }
                if(item == 5)
                {
                    ctr5++;
                }
            }

            if(ctr3 > ctr5)
            {
                return true;
            }
            return false;
        }
    }
}
