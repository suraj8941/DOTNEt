using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
        class Program
        {


        static void Main(string[] args)
            {
                
            Console.WriteLine("--------------------Mobile Database---------------------");
            Mobile[] mobiles = new Mobile[3];

            for (int i = 0; i < mobiles.Length; i++)
            {
                    int d_id; 
                    string d_name;
                    float d_price;

                    Console.WriteLine("=======================================================");
                    Console.Write("Enter id: ");
                    d_id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter name: ");
                    d_name = Console.ReadLine();

                    Console.Write("Enter price: ");
                    d_price = Convert.ToInt32(Console.ReadLine());

                    mobiles[i] = new Mobile(d_id, d_name, d_price);


            }
            for (int i = 0; i < mobiles.Length; i++)
            {

                mobiles[i].DisplayDetails();
            }

            Console.ReadLine();

            }
        }



}
