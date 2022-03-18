using System;

namespace Task93
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, -30, -40, 50 };

            var array1 = ReverseArr(arr);

            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
        }

        static int[] ReverseArr(int[] arr)
        {
            if(arr.Length % 2 == 0)
            {
                for(int i = 0; i < arr.Length / 2; i++)
                {
                    int temp = arr[i];
                    arr[i] = arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = temp;
                }
                return arr;
            }
            else
            {
                for(int i = 0; i < (arr.Length - 1) / 2; i++)
                {
                    int temp = arr[i];
                    arr[i] = arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = temp;
                }
                return arr;
            }
        }
    }
}
