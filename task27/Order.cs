using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib.book
{
    public class Order
    {
         public int id {get;set;}
         Order []o=new Order[0];
         public static double Price { get; set; }  
         public DateTime Date { get; set; }

        public void Pricer(book[] book)
        {
            foreach(var item in book)
            {
                Order.Price += item.Price;
            }
            if (Order.Price >= 100 && Order.Price < 200)
            {
                Order.Price = 0.9 * Order.Price ;
            }
            if (Order.Price >= 200 && Order.Price < 300)
            {
                Order.Price = 0.8 * Order.Price;
            }
            Console.WriteLine(Order.Price);

        }

    }                       
}
