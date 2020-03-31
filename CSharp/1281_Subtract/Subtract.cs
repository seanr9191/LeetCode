using System;

namespace _1281_Subtract
{
    class Subtract
    {
        public void run()
        {
            Console.WriteLine(SubtractProductAndSum(234));
        }

        public int SubtractProductAndSum(int n)
        {
            char[] numbers = n.ToString().ToCharArray();
            int product = 1;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = int.Parse(numbers[i].ToString());
                product *= num;
                sum += num;
            }
            return product - sum;
        }

        
    }
}
