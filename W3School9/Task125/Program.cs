using System;

namespace Task125
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 7, 5, 5, 3, 7 };
            int[] arr2 = new int[] { 3, 7, 5, 5, 3, 7 };
            int[] arr3 = new int[] { 3, 7, 5, 5, 3, 7, 5 };

            Console.WriteLine("Num: ");
            int num = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Validate(arr1, num));
                Console.WriteLine(Validate(arr2, num));
                Console.WriteLine(Validate(arr3, num));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static bool Validate(int[] arr, int num)
        {
            int ctr = 0;
            for (int i = 0; i < num; i++)
            {
                if(arr[i] == arr[arr.Length - num + i])
                {
                    ctr++;
                }
            }
            if(ctr == num)
            {
                return true;
            }
            return false;
        }
    }
}
