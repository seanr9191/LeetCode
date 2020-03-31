using System;

namespace _1351_Negative
{
    class Negative
    {
        static void Main(string[] args)
        {
            Negative p = new Negative();
            Console.WriteLine(p.CountNegatives(new int[][] { 
                new int[] { 4, 3, 2, -1 }, 
                new int[] { 3, 2, 1, -1 }, 
                new int[] { 1, 1, -1, -2 }, 
                new int[] { -1, -1, -2, -3 } 
            }));
        }

        public int CountNegatives(int[][] grid)
        {
            int len = grid[0].Length;
            int negs = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i][len - 1] < 0)
                {
                    for (int p = 0; p < len; p++)
                    {
                        if (grid[i][p] < 0)
                        {
                            negs += len - p;
                            p = len;
                        }
                    }
                }
            }
            return negs;
        }
    }
}
