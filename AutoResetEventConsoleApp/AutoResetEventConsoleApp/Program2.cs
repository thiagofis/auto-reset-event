using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventConsoleApp
{
    class Program2
    {
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        static string dataFromServer = "none";

        static void Main(string[] args)
        {
            Task task = Task.Factory.StartNew(() =>
            {
                GetDataFromServer();
            });

            //Put the current thread into waiting state until it receives the signal
            while (!autoResetEvent.WaitOne(TimeSpan.FromSeconds(5)))
            {
                Console.WriteLine("passaram 5 s");
                throw new Exception("kabummmm!!!");
            }

            //Thread got the signal
            Console.WriteLine(dataFromServer);
            Console.ReadKey();
        }

        static void GetDataFromServer()
        {
            //Calling any webservice to get data
            Thread.Sleep(TimeSpan.FromSeconds(8));
            Console.WriteLine("Esperei o server");
            dataFromServer = "Webservice data";
            autoResetEvent.Set();
        }
    }
}
