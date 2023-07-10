using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mathematics
    {
        public void SayHello(string name)
        {
            Console.WriteLine($" Hello {name} welcome to libraries");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
