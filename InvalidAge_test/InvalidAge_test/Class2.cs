using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidAge_test
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && age <= 80)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                throw new InvalidAgeException("Invalid Age");
            }

            Console.ReadLine();
        }
    }
}
