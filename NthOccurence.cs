using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//https://www.codewars.com/kata/554ca54ffa7d91b236000023/train/csharp
namespace CodeWars
{
    class NthOccurence
    {
        static void Main()
        {
            int[] result = DeleteNth(new int[] { 1, 1, 2, 3, 4, 5, 1 }, 3);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static int[] DeleteNth(int[] arr, int x)
        {
            Dictionary<int, int> uniqueValuesTable = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!uniqueValuesTable.ContainsKey(arr[i]))
                {
                    uniqueValuesTable.Add(arr[i], 1);
                }
                else
                {
                    uniqueValuesTable[arr[i]] += 1;                    
                }
            }
            Dictionary<int,int> temp = uniqueValuesTable;

            foreach (KeyValuePair<int, int> i in uniqueValuesTable.ToList())
            {
                if (i.Value >= x)
                {
                    temp.Remove(i.Key);
                }
            }

            uniqueValuesTable = temp;

            return uniqueValuesTable.Keys.ToArray();
        }

        
    }


}
