using System;

namespace Task135
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 6, 8 };
            int[] arr2 = new int[] { 15, 2, 3, 4, 15, 11 };

            Console.WriteLine(LargerAverage(arr1));
            Console.WriteLine(LargerAverage(arr2));
        }

        static int LargerAverage(int[] arr)
        {
            int sum1 = 0;
            int sum2 = 0;
            int ctr1 = 0;
            int ctr2 = 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                sum1 += arr[i];
                ctr1++;
            }
            for (int i = arr.Length / 2; i < arr.Length; i++)
            {
                sum2 += arr[i];
                ctr2++;
            }
            int avg1 = sum1 / ctr1;
            int avg2 = sum2 / ctr2;
            if(avg1 > avg2)
            {
                return avg1;
            }
            return avg2;
        }
    }
}
