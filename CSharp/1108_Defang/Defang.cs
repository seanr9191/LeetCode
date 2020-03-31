using System;

namespace _1108_Defang
{
    class Defang
    {
        public void run()
        {
            Console.WriteLine(DefangIPaddr("1.1.1.1"));
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

    }
}
