using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello, "); 
            Thread.Sleep(2000);  /*mSec */
            Console.WriteLine("World");
            Console.Read();
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(SayHello));
            t1.Start();
            
            Console.WriteLine("Thread started. Main done.");
        }
    }
}
