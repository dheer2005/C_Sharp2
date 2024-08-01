using System;

namespace Async_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }
        static void Calculate()
        {
            
            var task1 = Task.Run(() => 
            {
                return Calculate1();
            });
            var awaiter1 = task1.GetAwaiter();
            awaiter1.OnCompleted(() =>  
            {
                var result1 = awaiter1.GetResult();
                Calculate2(result1);
            });

            Calculate3();
            
            /*Task.WaitAll(task1,task2);
            var awaiter1 = task1.GetAwaiter();
            var awaiter2 = task2.GetAwaiter();
            var result1 = awaiter1.GetResult();
            var result2 = awaiter2.GetResult();
            Calculate3(result1, result2);*/
           /* Task.Run(() =>
            {
                Calculate3();
            });*/

            
        }
        static int Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculating result1");
            return 100;
        }
        static int Calculate2(int result1)
        {
            Console.WriteLine("calculating result2");
            return result1*2;
        }
        static int Calculate3() 
        {
            Console.WriteLine("Calculating result3");
            return 300;
        }  
    }
}