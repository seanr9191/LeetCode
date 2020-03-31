using System;
using System.Collections.Generic;
using System.Linq;

namespace _1313_Decompress
{
    class Decompress
    {
        static void Main(string[] args)
        {
            Decompress p = new Decompress();
            Console.WriteLine("[{0}]", string.Join(", ", p.DecompressRLElist(new int[] { 1, 2, 3, 4 })));
        }

        public int[] DecompressRLElist(int[] nums)
        {
            var output = new List<int>();
            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int p = 0; p < nums[i]; p++)
                {
                    output.Add(nums[i+1]);
                }
            }

            return output.ToArray();
        }
    }
}
