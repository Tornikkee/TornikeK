using System;

namespace Task112
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 6, 1, 5, 6, 9, 10, 17, 5, 6 };
            int[] arr2 = new int[] { 5, 6, 1, 5, 6, 9, 10, 17 };
            int[] arr3 = new int[] { 1, 5, 6, 9, 10, 17, 5, 6 };
            int[] arr4 = new int[] { 1, 5, 9, 10, 17, 5, 6 };
            int[] arr5 = new int[] { 1, 5, 9, 10, 17, 5 };
            int[] arr6 = new int[] { 5, 6, 6, 5, 6, 6, 6 };

            Console.WriteLine(SumElements(arr1));
            Console.WriteLine(SumElements(arr2));
            Console.WriteLine(SumElements(arr3));
            Console.WriteLine(SumElements(arr4));
            Console.WriteLine(SumElements(arr5));
            Console.WriteLine(SumElements(arr6));
        }

        static int SumElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(i < arr.Length - 1)
                {
                    if(arr[i] == 5 && arr[i + 1] == 6)
                    {
                        arr[i] = 0;
                        arr[i + 1] = 0;
                    }
                    if(arr[i] == 0 && arr[i + 1] == 6)
                    {
                        arr[i + 1] = 0;
                    }
                }
                sum += arr[i];
            }
            return sum;
        }
    }
}
