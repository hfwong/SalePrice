using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt operator for item price
            Console.WriteLine("Enter Item Price: ");
            string itemPriceString = Console.ReadLine();
            decimal itemPrice = Convert.ToDecimal(itemPriceString);

            decimal salePrice = itemPrice;
            decimal discount = 0;
            //determine sales discount
            if (itemPrice < 10)
                discount = 10;
            else
                discount = 20;
            //apply sales discount 
            salePrice = itemPrice * (1 - discount / 100);
            Console.WriteLine("");
            Console.WriteLine("Sales discount is {0}%.", discount);
            Console.WriteLine("Sale Price is ${0:0.00}", salePrice);
            Console.ReadLine();
        }
    }
}
