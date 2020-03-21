using System;
using System.Collections.Generic;


namespace CodeWars
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Test("1 3 2 7 9 11 13"));
        }

        static int Test(string numbers)
        {
            List<int> odds = new List<int>(new int[0]);
            List<int> evens = new List<int>(new int[0]);

            int[] numericValues = ConvertSentenceToIntegers(numbers);
            int originalValue = 0;
            int index = 0;

            for (int i = 0; i < numericValues.Length; i++)
            {
                if (numericValues[i] % 2 == 0)
                {
                    evens.Add(numericValues[i]);
                }
                else
                {
                    odds.Add(numericValues[i]);
                }

                if (odds.Count > 0 && evens.Count > 0)
                {
                    if (odds.Count >= 2)
                    {
                        originalValue = evens[0];
                        break;
                    }
                    else if (evens.Count >= 2)
                    {
                        originalValue = odds[0];
                        break;
                    }
                }
            }

            for (int i = 0; i < numericValues.Length; i++)
            {
                if (numericValues[i] == originalValue)
                {
                    index = i + 1;
                }
            }

            return index;
        }

        static int[] ConvertSentenceToIntegers(string numbers)
        {
            string[] values = numbers.Split(' ');
            int[] numericValues = new int[values.Length];

            for (int i = 0; i < numericValues.Length; i++)
            {
                numericValues[i] = Convert.ToInt32(values[i]);
            }

            return numericValues;
        }
    }
}
