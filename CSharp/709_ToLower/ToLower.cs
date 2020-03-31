using System;

namespace _709_ToLower
{
    class ToLower
    {
        static void Main(string[] args)
        {
            ToLower p = new ToLower();
            Console.WriteLine(p.ToLowerCase("LOVELY"));
        }

        public string ToLowerCase(string str)
        {
            return str.ToLower();
        }
    }
}
