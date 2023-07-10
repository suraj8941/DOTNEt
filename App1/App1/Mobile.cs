using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
        class Mobile{
         
         int id;
         string name;
         float price;
         
        public Mobile(int id,string name,float price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
      

            public void DisplayDetails()
            {    
                Console.WriteLine("\n\nName: "+ this.name + "  || Id: "+ this.id+ "  ||  Price: "+this.price);
            }
        }

}
