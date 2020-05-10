using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Second
{
    class Program
    {
        public Thread m_thread;
        string m_name;
        public Program(string name)
        {
            m_name = name;
            m_thread = new Thread(new ThreadStart(Worker));
        }
        private void Worker()
        {
            Console.WriteLine("Hello, ");
            Thread.Sleep(1500);
            Console.WriteLine(m_name);
        }
    }
    class TaskDemo1
    {
        static void Main(string[] args)
        {
            Program task1 = new Program("Bill");
            Program task2 = new Program("Steve");
            task1.m_thread.Start();
            task2.m_thread.Start();
            Console.Read();
        }
    }
}
