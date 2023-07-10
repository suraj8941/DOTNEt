using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_net_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee(){EmployeeID=1,EmpName="Samatha",Designation="Consultant",Department="Training",Salary=1234.33f },
                new Employee(){EmployeeID=2,EmpName="Namjoon",Designation="Consultant",Department="Training",Salary=1234.33f },
                new Employee(){EmployeeID=3,EmpName="Samuel",Designation="Consultant",Department="Training",Salary=1234.33f },
                new Employee(){EmployeeID=4,EmpName="Ritik",Designation="Consultant",Department="Training",Salary=1234.33f },
                new Employee(){EmployeeID=5,EmpName="KimTeahyung",Designation="Consultant",Department="Training",Salary=1234.33f },
                new Employee(){EmployeeID=6,EmpName="JHope",Designation="Consultant",Department="Training",Salary=1234.33f }
            };


            foreach (Employee emp in emps)
            {
                if (emp.EmpName.StartsWith("S") &&
                    emp.EmpName.Length > 5)
                {
                    Console.Write($"{emp.EmpName} ");
                }

            }

            Console.ReadLine();
        }
    }

}