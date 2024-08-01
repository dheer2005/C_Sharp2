using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    internal class DelegateExample
    {
        public void fun()
        {
            Console.WriteLine("Function Body");
        }

        public void fun1()
        {
            Console.WriteLine("Second Function Body");
        }

        public delegate void myDel();

        public static void main(string[] args)
        { 
            DelegateExample obj = new DelegateExample();
            myDel del = new myDel(obj.fun);
            del += obj.fun1;
            del();
            
        }
    }
}
