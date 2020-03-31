using System;

namespace _1108_Defang
{
    class Defang
    {
        static void Main(string[] args)
        {
            Defang p = new Defang();
            Console.WriteLine(p.DefangIPaddr("1.1.1.1"));
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

    }
}
