using System;

namespace _1221_Balance
{
    class Balance
    {
        static void Main(string[] args)
        {
            Balance p = new Balance();
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
