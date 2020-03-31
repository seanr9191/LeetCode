using System;

namespace _1342_Reduce
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.NumberOfSteps(100));
            Console.WriteLine(p.NumberOfSteps(14));
            Console.WriteLine(p.NumberOfSteps(8));
        }

        public int NumberOfSteps(int num)
        {
            int count = 0;
            while (num != 0) {
                if (num % 2 == 0)
                {
                    num /= 2;
                } else
                {
                    num--;
                }
                count++;
            }
            return count;
        }
    }
}
