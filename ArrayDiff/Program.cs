/* Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

It should remove all values from list a, which are present in list b.

Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
If a value is present in b, all of its occurrences must be removed from the other:

Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}

https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
*/
using System;

namespace ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalValues = ArrayDiff(new int[] {}, new int[] {});
            foreach (int i in originalValues)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }

        static int[] ArrayDiff(int[] a, int[] b)
        {
            int totalRepititions = 0;
            int[] tempValues = new int[a.Length];
            int tempIndex = 0;

            foreach (int verifiedElement in a)
            {
                bool isRepeated = false;
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i] == verifiedElement)
                    {
                        isRepeated = true;
                        totalRepititions++;
                    }                    
                }
                if (!isRepeated)
                {
                    tempValues[tempIndex++] = verifiedElement;
                }
            }

            int[] originalValues = new int[a.Length - totalRepititions];
            for (int i = 0; i < originalValues.Length; i++)
            {
                originalValues[i] = tempValues[i];
            }

            return originalValues;
        }
    }
}
