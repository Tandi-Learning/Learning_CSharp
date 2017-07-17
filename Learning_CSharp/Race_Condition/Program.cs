using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race_Condition
{
    class Program
    {
        static object locker = new object();
        private static int counter;
        private static int loopTimes = 500;
        static void Main(string[] args)
        {
            do
            {
                UsingThreadWithMonitor();
                var key = Console.ReadLine();
                if (key.ToLower() == "q")
                    break;
            } while (true);

        }

        private static void UsingThread()
        {
            // race condition
            Console.WriteLine("\r\nUsing Thread");
            Thread T1 = new Thread(() => PrintA());
            Thread T2 = new Thread(() => PrintB());

            T1.Start();
            T2.Start();
        }

        private static void UsingThreadWithJoin()
        {
            // no race condition
            Console.WriteLine("\r\nUsing Thread");
            Thread T1 = new Thread(() => PrintA());
            Thread T2 = new Thread(() => PrintB());

            T1.Start();
            T1.Join();
            T2.Start();
            T2.Join();
        }

        private static void UsingThreadWithLock()
        {
            // no race condition
            Console.WriteLine("\r\nUsing Thread");
            Thread T1 = new Thread(() => PrintALock());
            Thread T2 = new Thread(() => PrintBLock());

            T1.Start();
            T2.Start();
        }

        private static void UsingThreadWithMonitor()
        {
            // no race condition
            Console.WriteLine("\r\nUsing Thread");
            Thread T1 = new Thread(() => PrintAMonitor());
            Thread T2 = new Thread(() => PrintBMonitor());

            T1.Start();
            T2.Start();
        }

        private static void UsingTPL()
        {
            // race condition
            Console.WriteLine("\r\nUsing TPL");
            Task.Factory.StartNew(() => PrintA());
            Task.Factory.StartNew(() => PrintB());
        }

        private static void UsingTPLContinueWith()
        {
            // no race condition
            Console.WriteLine("\r\nUsing TPL");
            Task.Factory.StartNew(() => PrintA())
                .ContinueWith((t) => PrintB());
        }
        private static void PrintA()
        {
            for (counter = 0; counter < loopTimes; counter++)
            {
                Console.Write(" A ");
            }
        }

        private static void PrintB()
        {
            for (counter = 0; counter < loopTimes; counter++)
            {
                Console.Write(" B ");
            }
        }

        private static void PrintALock()
        {
            lock (locker)
            {
                for (counter = 0; counter < loopTimes; counter++)
                {
                    Console.Write(" A ");
                }
            }
        }

        private static void PrintBLock()
        {
            lock (locker)
            {
                for (counter = 0; counter < loopTimes; counter++)
                {
                    Console.Write(" B ");
                }
            }
        }

        private static void PrintAMonitor()
        {
            Monitor.Enter(locker);
            try
            {
                for (counter = 0; counter < loopTimes; counter++)
                {
                    Console.Write(" A ");
                }
            }
            finally
            {
                Monitor.Exit(locker);
            }
        }

        private static void PrintBMonitor()
        {
            Monitor.Enter(locker);
            try
            {
                for (counter = 0; counter < loopTimes; counter++)
                {
                    Console.Write(" B ");
                }
            }
            finally
            {
                Monitor.Exit(locker);
            }
        }
    }
}
