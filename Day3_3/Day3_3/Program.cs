using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileDemo1 fileDemo1 = new FileDemo1();
            //fileDemo1.WriteToFile();
            fileDemo1.ReadFromFile();

            Console.ReadLine();
        }
    }
}

