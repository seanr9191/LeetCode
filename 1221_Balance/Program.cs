using System;

namespace _1221_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.BalancedStringSplit("RLRRLLRLRL"));
            Console.WriteLine(p.BalancedStringSplit("RLLLLRRRLR"));
            Console.WriteLine(p.BalancedStringSplit("LLLLRRRR"));
            Console.WriteLine(p.BalancedStringSplit("RLRRRLLRLL"));
        }

        public int BalancedStringSplit(string s)
        {
            int count = 0;
            int tracker = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    tracker++;
                } else if (s[i] == 'L')
                {
                    tracker--;
                }
                if (tracker == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
