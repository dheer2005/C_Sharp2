using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface Bank
    {
        abstract public void Credit(int amt);
        abstract public void Debit(int amt);
        abstract public bool Login(int pincode);
        abstract public void CheckBalance();

        
    }
}
