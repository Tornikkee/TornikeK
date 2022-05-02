using System;
using System.Collections.Generic;

namespace LeetCodeExercies_Tornike_Khamitsashvili_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int[] nums1 = new int[] { 3, 2, 4 };
            int[] nums2 = new int[] { 3, 7, 11, 15 };

            int target = 9;
            int target1 = 6;
            int target2 = 9;
            try
            {
                var result = TwoSum(nums, target);
                foreach (var item in result)
                {
                    Console.Write(item + " ");
                }

                Console.Write("\n");
                Console.WriteLine("..........");

                var result1 = TwoSum(nums1, target1);
                foreach (var item in result1)
                {
                    Console.Write(item + " ");
                }

                Console.Write("\n");

                var result2 = TwoSum(nums2, target2);
                foreach (var item in result2)
                {
                    Console.Write(item + " ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int[] TwoSum(int[] nums, int target)
        {
            List<int> numbers = new List<int>();
            numbers.AddRange(nums);
            numbers.Sort();
            int lowNumIndex = 0;
            int highNumIndex = numbers.Count - 1;

            while(lowNumIndex <= highNumIndex)
            {
                int result = numbers[lowNumIndex] + numbers[highNumIndex];
                if(result > target)
                {
                    highNumIndex--;
                }
                else if(result < target)
                {
                    lowNumIndex++;
                }
                else
                {
                    return new int[] { lowNumIndex, highNumIndex };
                }
            }
            throw new Exception("Target not found");
        }
    }
}
