using System;

namespace _1266_Minimum
{
    class Minimum
    {
        static void Main(string[] args)
        {
            Minimum p = new Minimum();

            var points = new int[][] { new int[] { 1, 1 }, new int[] { 3, 4 }, new int[] { -1, 0 } };
            Console.WriteLine(p.MinTimeToVisitAllPoints(points));
        }

        public int MinTimeToVisitAllPoints(int[][] points)
        {
            if (points == null)
                return -1;

            int sum = 0;
            for (int i = 0; i < points.Length-1; i++)
            {
                sum += timeBetween(points[i], points[i + 1]);
            }

            return sum;
        }

        public int timeBetween(int[] point1, int[] point2)
        {
            int a = Math.Abs(point1[0] - point2[0]);
            int b = Math.Abs(point1[1] - point2[1]);
            return Math.Max(a, b);
        }

    }
}
