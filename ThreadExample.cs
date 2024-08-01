using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    internal class ThreadExample
    {
        public static void Display()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Process" + i);
                Thread.Sleep(1000);
            }
        }

        public static void Main(string[] args)
        {
            ThreadStart obj = new ThreadStart(ThreadExample.Display);
            Thread t = new Thread(obj);
            t.Start();

            //for synchronous process(second program will run after first program execution
            t.Join();
            //For multi Threading
            Thread t1 = new Thread(obj);
            t1.Start();
        }
    }
}
