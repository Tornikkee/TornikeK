using System;

namespace Task118
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 5, 5, 5, 5 };
            int[] arr2 = new int[] { 3, 3, 3, 3 };
            int[] arr3 = new int[] { 3, 3, 3, 5, 5, 5 };
            int[] arr4 = new int[] { 1, 6, 8, 10 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
            Console.WriteLine(Validate(arr4));
        }

        static bool Validate(int[] arr)
        {
            int contains3 = 0;
            int contains5 = 0;

            foreach (var item in arr)
            {
                if(item == 3)
                {
                    contains3++;
                }
                if(item == 5)
                {
                    contains5++;
                }
            }

            if((contains3 > 0 && contains5 == 0) || (contains5 > 0 && contains3 == 0) || (contains3 == 0 && contains5 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
