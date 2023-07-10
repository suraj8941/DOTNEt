using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_net_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Make a choice : 1 or 2 :");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)                        // Using switch case to implement 
            {
                case 1:
                    Interface1 obj1 = new TestInterface();
                    obj1.Method1();
                    break;

                case 2:
                    Interface2 obj2 = new TestInterface();
                    obj2.Method1();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
