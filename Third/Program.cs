using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Third
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello, ");
            Thread.Sleep(750 /*mSec */);
            Console.WriteLine("World");
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(SayHello));
            Thread thread2 = new Thread(new ThreadStart(SayHello));
            thread1.Start();
            thread2.Start();
            thread1.Join(); //Calling Join() on a thread causes the calling thread to pause execution until the called thread has completed
            thread2.Join();
            Console.WriteLine("Thread started. Main done.");
            Console.ReadLine();// Wait, so you can see output.           
        }
    }
}

    

