using System;

//https://www.codewars.com/kata/537529f42993de0e0b00181f/train/csharp

namespace CalcInversionsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountInversions(new int[] { 6, 5, 4, 3, 3, 3, 3, 2, 1 }));
        }

        static int CountInversions(int[] array)
        {
            int inversionsCounter = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] - array[j] > 0)
                    {
                        inversionsCounter++;
                    }
                }
            }
            return inversionsCounter;
        }
    }
}
