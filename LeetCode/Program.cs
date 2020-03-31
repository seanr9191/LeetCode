using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.DefangIPaddr("1.1.1.1"));
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

    }
}
