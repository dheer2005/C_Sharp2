using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class BillingNew:Billing
    {
        public override float calcBill(int finalamount)
        {
            return finalamount + (finalamount * 0.18F);
        }

        /*public static void Main(string[] args)
        {
            //method overhiding
            Billing obj = new BillingNew();
            Console.WriteLine("Due to Method overhiding total bill is: {0}",obj.calcBill(100));//output will 100 = thats why this is called method overhiding

            //method overriding
            BillingNew obj1 = new BillingNew();
            Console.WriteLine("Due to Method overriding total bill is: {0}",obj1.calcBill(100));//output will 118 = thats why this is called method overriding
        }*/
    }
}
