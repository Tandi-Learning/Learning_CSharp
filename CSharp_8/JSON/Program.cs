using System;
using static System.Console;

namespace JSON
{
    class Program
    {
        static JSONSample jsonSample = new JSONSample();

        static void Main(string[] args)
        {
            var key = ' ';
            do {
                ListOptions();
                key = ReadKey(true).KeyChar;
                ProcessResponse(key);

            } while (key.ToString().ToLower() != "q");
        }

        static void ListOptions()
        {
            WriteLine();
            WriteLine("C# 8 Pattern Matching");
            WriteLine("-----------------------------");
            WriteLine("1. Utf8JsonReader");
            WriteLine("-----------------------------");
            WriteLine("Q. Quit");
            WriteLine();
        }

        static void ProcessResponse(Char key)
        {
            switch(key) 
            {
                case '1':
                {
                    jsonSample.Utf8JsonReader();
                    break;
                }
                default:
                {
                    break;
                }

            }
        }
    }
}
