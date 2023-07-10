using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_test
{
    internal class TestInterface : Interface1, Interface2
    {
        void Interface1.Method1()
        {
            Console.WriteLine("Method1 of Interface1");

        }

        void Interface2.Method1()
        {
            Console.WriteLine("Method1 of Interface2");
        }
    }
}
