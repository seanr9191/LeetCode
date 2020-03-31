using System;

namespace _1221_Balance
{
    class Balance
    {
        public void run()
        {
            Console.WriteLine(BalancedStringSplit("RLRRLLRLRL"));
            Console.WriteLine(BalancedStringSplit("RLLLLRRRLR"));
            Console.WriteLine(BalancedStringSplit("LLLLRRRR"));
            Console.WriteLine(BalancedStringSplit("RLRRRLLRLL"));
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
