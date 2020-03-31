using System;
using System.Collections.Generic;
using System.Linq;

namespace _1365_Smaller
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("[{0}]", string.Join(", ", p.SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 })));
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var counts = new Dictionary<int, int>();
            var sortedNums = nums.OrderBy(x => x).ToArray();

            for (int i = 0; i < sortedNums.Length; i++)
            {
                if (!counts.ContainsKey(sortedNums[i]))
                {
                    counts.Add(sortedNums[i], i);
                }
            }

            var output = new int[nums.Length];
            for (int i = 0; i < sortedNums.Length; i++)
            {
                output[i] = counts[nums[i]];
            }
            return output;

        }
    }
}
