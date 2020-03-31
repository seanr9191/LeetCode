using System;
using System.Text;

namespace _1323_Max69
{
    class Max69
    {
        static void Main(string[] args)
        {
            Max69 p = new Max69();
            Console.WriteLine(p.Maximum69Number(9669));
        }

        public int Maximum69Number(int num)
        {
            var n = num.ToString();
            if (n.Contains("6")) {
                var sb = new StringBuilder(n);
                sb[n.IndexOf('6')] = '9';
                return int.Parse(sb.ToString());
            }
            return num;
        }
    }
}
