using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //interface
    internal class BankImplementation : Bank, Promotion
    {

        int balance = 20000;
        public void CheckBalance()
        {
            if (this.Login(1111))
            {
                Console.WriteLine("Balance is {0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }

        }

        public void Credit(int amt)
        {
            if (this.Login(1111))
            {
                balance += amt;
                CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }

        }

        public void Debit(int amt)
        {
            if (this.Login(1111))
            {
                balance -= amt;
                CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }
        }

        public bool Login(int pincode)
        {
            if (pincode == 1111)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void marketing()
        {
            Console.WriteLine("Marketing");
        }

        public void branding()
        {
            Console.WriteLine("Promotion");
        }
    }




    /*internal class BankImplementation : Bank
    {
        internal int balance = 12000;
        public override void CheckBalance()
        {
            if (this.Login(1111))
            {
                Console.WriteLine("Balance is {0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }
            
        }

        public override void Credit(int amt)
        {
            if (this.Login(1111))
            {
                balance += amt;
                CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }
            
        }

        public override void Debit(int amt)
        {
            if (this.Login(1111))
            {
                balance -= amt;
                CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid Pin Code");
            }
        }

        public override bool Login(int pincode)
        {
            if (pincode == 1111)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }*/
}
