using System;

namespace Task134
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 5, 1, 15, 15 };
            int[] arr2 = new int[] { 15, 2, 3, 4, 15 };
            int[] arr3 = new int[] { 3, 3, 15, 15, 5, 5 };
            int[] arr4 = new int[] { 1, 5, 15, 7, 8, 15 };
            int[] arr5 = new int[] { 15, 15 };
            int[] arr6 = new int[] { 12, 14 };
            int[] arr7 = new int[] { 3 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
            Console.WriteLine(Validate(arr4));
            Console.WriteLine(Validate(arr5));
            Console.WriteLine(Validate(arr6));
            try
            {
                Console.WriteLine(Validate(arr7));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static bool Validate(int[] arr)
        {
            if(arr.Length < 2)
            {
                throw new Exception("array length can not be less than 2...");
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 15 && arr[i + 1] == 15)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
