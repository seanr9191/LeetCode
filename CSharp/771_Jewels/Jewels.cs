using System;
using System.Linq;


namespace _771_Jewels
{
    class Jewels
    {
        static void Main(string[] args)
        {
            Jewels p = new Jewels();
            Console.WriteLine(p.NumJewelsInStones("aA", "aAAbbbb"));
        }

        public int NumJewelsInStones(string J, string S)
        {
            return S.Count(stone => J.Contains(stone));
            /*
            int count = 0;
            J.ToCharArray().ToList().ForEach(c => count += S.ToCharArray().ToList().Where(d => c == d).Count());
            return count;
            */

        }
    }
}
