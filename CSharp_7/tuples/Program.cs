using System;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while (true)
            {
                ShowMenu();
                var key = Console.ReadLine();
                HandeMenu(Int32.Parse(key));
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Tuple One");
            Console.WriteLine("======================================");
        }

        static void HandeMenu(int id)
        {
            switch(id) 
            {
                case 1:  {
                    var obj = new Tuple_One();
                    obj.Run();
                    break;
                }
            }
        }
    }
}
