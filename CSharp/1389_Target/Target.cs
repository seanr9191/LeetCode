using System;
using System.Collections.Generic;

namespace _1389_Target
{
    class Target
    {
        static void Main(string[] args)
        {
            Target p = new Target();
            Console.WriteLine("[{0}]", string.Join(", ", p.CreateTargetArray(new int[] { 0, 1, 2, 3, 4 }, new int[] { 0, 1, 2, 2, 1 })));
            Console.WriteLine("[{0}]", string.Join(", ", p.CreateTargetArray(new int[] { 1, 2, 3, 4, 0 }, new int[] { 0, 1, 2, 3, 0 })));
        }

        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> target = new List<int>();
            for (int i = 0; i <nums.Length; i++)
            {
                target.Insert(index[i], nums[i]);
            }

            return target.ToArray();
        }
    }
}
