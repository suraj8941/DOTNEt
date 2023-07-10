
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Service_1.ServiceReference2;
namespace Console_Service_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String User_name;
            int Pass;
            Login_itSoapClient obj = new Login_itSoapClient();
            
            Console.WriteLine("Enter Username: ");
            User_name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            Pass= Convert.ToInt32(Console.ReadLine());

            if (obj.Login_i(User_name, Pass) == true)
            {
                Console.WriteLine("Authentication Approve.");

            }
            else
            {
                Console.WriteLine("Authentication Disapprove.");

            }
            Console.ReadLine();
            

        }
    }
}
