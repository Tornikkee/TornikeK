using System;

namespace Task102
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, 7, 19, 21, 45 };
            int[] arr2 = new int[] { 48, 0, 14, 18, 4 };

            var arr = LargerSum(arr1, arr2);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static int[] LargerSum(int[] arr1, int[] arr2)
        {
            int sum1 = 0;
            int sum2 = 0;
            foreach (var item in arr1)
            {
                sum1 += item;
            }
            foreach (var item in arr2)
            {
                sum2 += item;
            }
            
            if(sum1 > sum2)
            {
                return arr1;
            }
            else if(sum2 > sum1)
            {
                return arr2;
            }
            else
            {
                return arr1;
            }
        }
    }
}
