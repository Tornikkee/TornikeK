using System;

namespace Task94
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, -20, 99, 53, -100, 15, 407, -200 };
            ChangeArr(arr);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static int[] ChangeArr(int[] arr)
        {
            int largest = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(i == 0)
                {
                    largest = arr[i];
                }
                if(largest < arr[i])
                {
                    largest = arr[i];
                }
            }
            
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = largest;
            }

            return arr;
        }
    }
}
