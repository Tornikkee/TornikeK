using System;

namespace B.VladAndCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCases = Convert.ToInt32(Console.ReadLine());
            if(inputCases >= 1 && inputCases <= 10000)
            {
                for (int i = 0; i < inputCases; i++)
                {
                    Console.Write("Number of Types: ");
                    int numberOfTypes = Convert.ToInt32(Console.ReadLine());

                    int[] candies = new int[numberOfTypes];

                    for (int j = 0; j < numberOfTypes; j++)
                    {
                        Console.Write($"Enter candy amount for type {j + 1}: ");
                        int candyNumber = Convert.ToInt32(Console.ReadLine());
                        candies[j] = candyNumber;
                    }

                    Console.WriteLine(Validate(numberOfTypes, candies));
                }
            } 
        }

        static string Validate(int numberOfTypes, int[] candies)
        {
            if(candies.Length <= 1)
            {
                if(candies[0] > 1)
                {
                    return "NO";
                }
            }
            for(int i = 0; i < numberOfTypes; i++)
            {
                for(int j = 1; j < numberOfTypes - 1; j++)
                {
                    if(candies[i] - candies[j] > 1)
                    {
                        return "NO";
                    }
                }
            }
            return "YES";
        }
    }
}
