using System;
using System.Linq;

namespace _1295_Even
{
    class Even
    {
        public void run()
        {
            Console.WriteLine(FindNumbers(new int[] { 12, 345, 2, 6, 7896 }));
        }

        public int FindNumbers(int[] nums)
        {
            return nums.Count(n => n.ToString().Length % 2 == 0);
        }
    }
}
