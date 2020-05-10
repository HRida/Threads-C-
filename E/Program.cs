using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace E
{
    class Program
    {
        static object myLockObject = new Object();
        static void SayHello()
        {
            Console.WriteLine("Hello, ");
            Thread.Sleep(1000); Monitor.Enter(myLockObject);
            // Acquire the lock.        
            Console.WriteLine("Wonderful ");
            // This section of code       
            Thread.Sleep(1000);
            // is run by only one      
            Console.WriteLine("World");
            // thread at a time.     
            Monitor.Exit(myLockObject);
            // Release the lock.     
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(SayHello));
            Thread thread2 = new Thread(new ThreadStart(SayHello));
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }

    }
}
