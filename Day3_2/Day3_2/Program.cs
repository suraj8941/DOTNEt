using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer t1 = new Trainer(1, "samatha", ".Net");
            t1.DisplayDetails();
            t1.SaySomething();
            Console.ReadLine();
        }
    }
}

