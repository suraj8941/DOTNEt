using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Day3

{
    class Class2
    {
        Mathematics obj = new Mathematics();
        public string name;
        public int a, b;
        public void CallSayHello()
        {
            obj.SayHello(name);

        }

        public void CallAdd()
        {
            Console.WriteLine($"Result is {obj.Add(a, b)}");
        }
    }
}
