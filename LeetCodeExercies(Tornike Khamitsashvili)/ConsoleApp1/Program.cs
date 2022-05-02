using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int[] nums1 = new int[] { 3, 2, 4 };
            int target = 9;
            int target1 = 6;

            var result = TwoSum(nums, target);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var result1 = TwoSum(nums1, target1);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
        }

        static int[] TwoSum(int[] numbers, int target)
        {
            var low = 0;
            var high = numbers.Length - 1;
            while (low <= high)
            {
                var result = numbers[low] + numbers[high];
                if (result > target)
                {
                    high--;
                }
                else if (result < target)
                {
                    low++;
                }
                else
                {
                    return new int[] { low, high };
                }
            }
            throw new Exception("target not found");
        }
    }
}
