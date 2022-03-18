using System;

namespace Task100
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 10 };
            int[] arr2 = new int[] { 20, 20 };
            int[] arr3 = new int[] { 12, 20 };
            int[] arr4 = new int[] { 10 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
            Console.WriteLine(Validate(arr4));
        }

        static bool Validate(int[] arr)
        {
            int ctr = 0;
            foreach (var item in arr)
            {
                if(item == 10)
                {
                    ctr++;
                }
                if(ctr == 2)
                {
                    return true;
                }
            }

            foreach (var item in arr)
            {
                if (item == 20)
                {
                    ctr++;
                }
                if (ctr == 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
