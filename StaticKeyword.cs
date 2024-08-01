using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals2
{
    static class StaticKeyword
    {
        public static int productId;
        public static string productName;
        public static int productPrice;

        static StaticKeyword() {
            productId = 111;
            productName = "Guitar";
            productPrice = 5000;
        }

        public static void GetProductDetails()
        {
            Console.WriteLine("Product id is {0} ", productId);
            Console.WriteLine("Product name is {0}", productName);
            Console.WriteLine("Product price is {0}", productPrice);
        }

        public static void getDiscount() {
            int d_amount = productPrice / 10;
            Console.WriteLine("Total discount is {0}", d_amount);
            Console.WriteLine("Total cost of product is {0}",(productPrice - d_amount));
        }

    }

    class Program 
    {
        public static void main(string[] args)
        {
            StaticKeyword.GetProductDetails();

        }
    }

}
