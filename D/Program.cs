using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace D
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello, ");
            Thread.Sleep(15000); // Something goes wrong, here.         
            Console.WriteLine("World");
            Console.ReadLine();// Wait, so you can see output. 
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(SayHello));
            thread1.Start();
            thread1.Join(10000);
            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread 1 timed out. I am killing it.");
                thread1.Abort();
                Console.ReadLine();// Wait, so you can see output.
            }

        }
    }
}
