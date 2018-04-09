using System;

namespace Async_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Async_01 async01 = new Async_01();
            var info = async01.ShowTodaysInfo();
            System.Console.WriteLine(info);
        }
    }
}
