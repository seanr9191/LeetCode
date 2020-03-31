using System;

namespace _709_ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.ToLowerCase("LOVELY"));
        }

        public string ToLowerCase(string str)
        {
            return str.ToLower();
        }
    }
}
