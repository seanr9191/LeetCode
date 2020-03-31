using System;
using System.Linq;

namespace _1295_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.FindNumbers(new int[] { 12, 345, 2, 6, 7896 }));
        }

        public int FindNumbers(int[] nums)
        {
            return nums.Count(n => n.ToString().Length % 2 == 0);
        }
    }
}
