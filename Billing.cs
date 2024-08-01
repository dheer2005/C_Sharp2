using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Billing
    {
        /*//method hiding
        public float calcBill(int finalamount)
        {
            return finalamount;
        }*/
        //method overriding
        public virtual float calcBill(int finalamount)
        {
            return finalamount;
        }
    }
}
