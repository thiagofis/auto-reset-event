using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventConsoleApp
{
    class Program
    {
        static AutoResetEvent autoResetEvent;

        //static void Main(string[] args)
        //{
        //    autoResetEvent = new AutoResetEvent(false);

        //    while (!autoResetEvent.WaitOne(TimeSpan.FromSeconds(1)))
        //    {
        //        Console.WriteLine("Continue");
        //        StopEvent();
        //    }

        //    Console.WriteLine("Thread got signal");

        //    Console.ReadKey();
        //}

        static void StopEvent()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            autoResetEvent.Set();
        }
    }
}
