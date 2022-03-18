using System;

namespace Task140
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 5, 7, 9, 10 };
            Console.Write("Enter array length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[0]; 
            try
            {
                arr1 = NewArr(arr, length);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
        }

        static int[] NewArr(int[] arr, int length)
        {
            int ctr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                    ctr++;
                }
            }
            if(length > ctr)
            {
                throw new Exception($"Given array has less odd numbers than your input ({ctr} odd numbers exactly), there is no need to waste memory, please try again and choose {ctr} or lower number for input, Thank you for your understanding <3");
            }

            int[] arr1 = new int[length];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(index == length)
                {
                    break;
                }
                if(arr[i] % 2 != 0)
                {
                    arr1[index] = arr[i];
                    index++;
                }
            }

            return arr1;
        }
    }
}
