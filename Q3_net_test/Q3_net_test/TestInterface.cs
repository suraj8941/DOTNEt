using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_net_test
{
    internal class TestInterface : Interface1, Interface2     // Both interfaces inherited by Testinterface
    {
        void Interface1.Method1()                      // Test interface 1 method called
        {
            Console.WriteLine("Method1 of Interface1");

        }

        void Interface2.Method1()                       // Test interface 1 method called
        {
            
            Console.WriteLine("Method1 of Interface2");
        }
    }
}