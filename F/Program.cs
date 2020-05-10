using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.CompilerServices;

namespace F
{
    class Program
    {
        static object myLockObject = new Object();
        static void SayHello()
        {
            Console.WriteLine("Hello, ");
            Thread.Sleep(1000);
            lock (myLockObject)
            {
                // Acquire the lock.           
                Console.WriteLine("Wonderful "); // This code   
                Thread.Sleep(1000);              // is run by only one       
                Console.WriteLine("World");
                // thread at a time.     
            }
            // Release the lock.      
            SayHello2();
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        static void SayHello2()
        {
            // This entire method is      
            Console.WriteLine("Hello, ");    // run by only one    
            Thread.Sleep(1000);              // thread at a time.    
            Console.WriteLine("Wonderful "); // ...      
            Thread.Sleep(1000);              // ...      
            Console.WriteLine("World");      // ...     
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
