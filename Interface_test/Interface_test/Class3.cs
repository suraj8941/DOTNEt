using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_test
{
 
     internal class Class3
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("select an option 1/2");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
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
