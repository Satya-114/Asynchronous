using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program execution begins");
            Method1();
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("for loop:"+i);
            }
        }
        private static async void Method1()
        {
             int value =await Method2();
            Console.WriteLine("output of Method2 :" + value);
        }
        private static Task<int> Method2()
        {
            //Thread.Sleep(5000);
            //return 1;
            return Task.Run(() =>
            { 
                Thread.Sleep(5000); 
                return 1; 
            });
        }
    }
}
