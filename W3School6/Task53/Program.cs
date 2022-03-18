using System;

namespace Task53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 2, 4, 7, 18, 19, 10, 2022 };
            int[] arr2 = new int[] { 4, 6, 8, 10, 20, 24, 40, 2000 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
        }

        static bool Validate(int[] arr)
        {
            foreach (var item in arr)
            {
                if(item % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
