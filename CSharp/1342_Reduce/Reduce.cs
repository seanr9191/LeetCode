using System;

namespace _1342_Reduce
{
    class Reduce
    {
        public void run()
        {
            Console.WriteLine(NumberOfSteps(100));
            Console.WriteLine(NumberOfSteps(14));
            Console.WriteLine(NumberOfSteps(8));
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
