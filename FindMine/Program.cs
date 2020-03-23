using System;

namespace FindMine
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int> coords = MineLocation(new int[,] { { 0, 0, 0 }, { 0, 0, 1 }, { 0, 0, 0 }, { 0,0,0} });
            Console.WriteLine("Mine detected at coordinates: {0}:{1}", coords.Item1,coords.Item2);
        }

        static Tuple<int, int> MineLocation (int[,] field)
        {
            int dimensionLength = field.GetLength(0);
            int totalLength = field.Length;
            if (Math.Sqrt(totalLength) == dimensionLength)                         //Check that the array is rectangular type
            {
                for (int i = 0; i < dimensionLength; i++)
                {
                    for (int j = 0; j < dimensionLength; j++)
                    {
                        if (field[i, j] == 1)
                        {
                            return Tuple.Create(i, j);
                        }
                    }
                }
            }

            return Tuple.Create(-1, -1);
        }
    }
}
