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
            int[] originalValues = ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2});
            foreach (int i in originalValues)
            {
                Console.WriteLine(i);                
            }
        }

        static int[] ArrayDiff(int[] a, int[] b)
        {
            int repititions = 0;
            bool isRepeated = false;

            foreach (int i  in b)
            {
                foreach (int j in a)
                {
                    if (i == j)
                    {
                        repititions++;
                    }
                }
            }
            
            int[] original = new int[a.Length - repititions];
            int index = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if(!isRepeated)
                {
                    original[index] = a[i];
                    index++;
                    isRepeated = false;
                }
                isRepeated = false;                                
            }

            return original;
        }
    }
}
