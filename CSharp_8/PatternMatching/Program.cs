using System;
using static System.Console;

namespace PatternMatching
{
    class Program
    {
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
            WriteLine("1. Positional");
            WriteLine("2. Property");
            WriteLine("3. Switch");
            WriteLine("4. Tuple");
            WriteLine("q. Quit");
            WriteLine();
        }

        static void ProcessResponse(Char key)
        {
            PatternSample sample = new PatternSample();
            Teacher John = new Teacher("John", "Doe", "Math");
            Teacher Jane = new Teacher("John", "Doe", "Biology");
            Student Diana = new Student("Diana", "Wonder", John, 7);
            Student Scarlet = new Student("Scarlet", "Clark", Jane, 7);
            switch(key)
            {
                case '1': 
                {
                    WriteLine($"Is {Diana.FullName} in 7th grade Math class ? {sample.IsInSeventhGradeMathPositional(Diana)}");
                    WriteLine($"Is {Scarlet.FullName} in 7th grade Math class ? {sample.IsInSeventhGradeMathPositional(Scarlet)}");
                    break;
                }
                case '2': 
                {
                    WriteLine($"Is {Diana.FullName} in 7th grade Math class ? {sample.IsInSeventhGradeMathProperty(Diana)}");
                    WriteLine($"Is {Scarlet.FullName} in 7th grade Math class ? {sample.IsInSeventhGradeMathProperty(Scarlet)}");
                    break;
                }
                case '3': 
                {
                    WriteLine($"{John.FullName} is Math teacher ? {sample.WhatIsPerson(John)}");
                    WriteLine($"{Jane.FullName} is Math teacher ? {sample.WhatIsPerson(Jane)}");
                    WriteLine($"{Diana.FullName} is 7th grade Math student ? {sample.WhatIsPerson(Diana)}");
                    WriteLine($"{Scarlet.FullName} is 7th grade Math student ? {sample.WhatIsPerson(Scarlet)}");
                    break;
                }
                case '4': 
                {
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
