using System;

namespace Task124
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 5, 5, 3, 7 };
            int[] arr2 = new int[] { 3, 5, 5, 4, 1, 5, 7 };
            int[] arr3 = new int[] { 3, 5, 5, 5, 5, 5 };
            int[] arr4 = new int[] { 2, 4, 5, 5, 6, 7, 5 };

            Console.WriteLine(Validate(arr1));
            Console.WriteLine(Validate(arr2));
            Console.WriteLine(Validate(arr3));
            Console.WriteLine(Validate(arr4));
        }

        static bool Validate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(i < arr.Length - 1 && i > 0)
                {
                    if((arr[i] == 5 && arr[i + 1] != 5) && (arr[i] == 5 && arr[i - 1] != 5))
                    {
                        return false;
                    }
                }
                if(i == 0)
                {
                    if(arr[i] == 5 && arr[i + 1] != 5)
                    {
                        return false;
                    }
                }
                if(i == arr.Length - 1)
                {
                    if(arr[i] == 5 && arr[i - 1] != 5)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
