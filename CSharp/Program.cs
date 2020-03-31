using System;
using System.Text;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var defang = new _1108_Defang.Defang();
            WriteHeader("1108. Defanging an IP Address");
            defang.run();
            WriteFooter();

            var reduce = new _1342_Reduce.Reduce();
            WriteHeader("1342. Number of Steps to Reduce a Number to Zero");
            reduce.run();
            WriteFooter();

            var smaller = new _1365_Smaller.Smaller();
            WriteHeader("1365. How Many Numbers Are Smaller Than the Current Number");
            smaller.run();
            WriteFooter();

            var jewels = new _771_Jewels.Jewels();
            WriteHeader("771. Jewels and Stones");
            jewels.run();
            WriteFooter();

            var decompress = new _1313_Decompress.Decompress();
            WriteHeader("1313. Decompress Run-Length Encoded List");
            decompress.run();
            WriteFooter();

            var even = new _1295_Even.Even();
            WriteHeader("1295. Find Numbers with Even Number of Digits");
            even.run();
            WriteFooter();

            var subtract = new _1281_Subtract.Subtract();
            WriteHeader("1281. Subtract the Product and Sum of Digits of an Integer");
            subtract.run();
            WriteFooter();

            var target = new _1389_Target.Target();
            WriteHeader("1389. Create Target Array in the Given Order");
            target.run();
            WriteFooter();

            var balance = new _1221_Balance.Balance();
            WriteHeader("1221. Split a String in Balanced Strings");
            balance.run();
            WriteFooter();

            var rangesum = new _938_RangeSum.RangeSum();
            WriteHeader("938. Range Sum of BST");
            rangesum.run();
            WriteFooter();

            var binary = new _1290_binary.Binary();
            WriteHeader("1290. Convert Binary Number in a Linked List to Integer");
            binary.run();
            WriteFooter();

            var minimum = new _1266_Minimum.Minimum();
            WriteHeader("1266. Minimum Time Visiting All Points");
            minimum.run();
            WriteFooter();

            var toLower = new _709_ToLower.ToLower();
            WriteHeader("709. To Lower Case");
            toLower.run();
            WriteFooter();

            var replace = new _1299_Replace.Replace();
            WriteHeader("1299. Replace Elements with Greatest Element on Right Side");
            replace.run();
            WriteFooter();

            var max69 = new _1323_Max69.Max69();
            WriteHeader("1323. Maximum 69 Number");
            max69.run();
            WriteFooter();

            var negative = new _1351_Negative.Negative();
            WriteHeader("1351. Count Negative Numbers in a Sorted Matrix");
            negative.run();
            WriteFooter();
        }

        private static void WriteHeader(String name)
        {
            /* 58 spaces */
            int numSpots = 58 - name.Length;
            int lSpot, rSpot;
            if (numSpots % 2 == 0)
            {
                lSpot = rSpot = (numSpots / 2);
            } else
            {
                lSpot = (numSpots / 2);
                rSpot = lSpot + 1;
            }
            StringBuilder lString = new StringBuilder("*");
            StringBuilder rString = new StringBuilder("*");
            for (int i = 0; i < lSpot; i++)
            {
                lString.Append(" ");
            }
            for (int i = 0; i < rSpot; i++)
            {
                rString.Insert(0, " ");
            }

            Console.WriteLine("************************************************************");
            Console.WriteLine("*                                                          *");
            Console.WriteLine(lString.ToString() + name + rString.ToString());
            Console.WriteLine("*                                                          *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("");
        }

        private static void WriteFooter()
        {
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
