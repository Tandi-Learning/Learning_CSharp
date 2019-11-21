using System;
using static System.Console;

namespace PatternMatching
{
    class Program
    {
        static PatternSample sample = new PatternSample();
        static Teacher John = new Teacher("John", "Doe", "Math");
        static Teacher Jane = new Teacher("Jane", "Doe", "Biology");
        static Student Diana = new Student("Diana", "Wonder", John, 7);
        static Student Scarlet = new Student("Scarlet", "Clark", Jane, 7);
        static Student Logan = new Student("Logan", "Sunarto", John, 5);
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
                    WriteLine($"Is {John.FullName} a Math teacher ? {sample.WhatIsPerson(John)}");
                    WriteLine($"Is {Jane.FullName} a Math teacher ? {sample.WhatIsPerson(Jane)}");
                    WriteLine($"Is {Diana.FullName} a 7th grade Math student ? {sample.WhatIsPerson(Diana)}");
                    WriteLine($"Is {Scarlet.FullName} a 7th grade Math student ? {sample.WhatIsPerson(Scarlet)}");
                    WriteLine($"Is {Logan.FullName} a 6th grade Math student ? {sample.WhatIsPerson(Logan)}");
                    break;
                }
                case '4': 
                {
                    WriteLine($"Is {Logan.FullName} a 7th grade Math student ? {sample.WhatIsPersonWithTuple(Logan, Jane)}");
                    WriteLine($"Is {Scarlet.FullName} a 7th grade Math student ? {sample.WhatIsPersonWithTuple(Scarlet, John)}");
                    WriteLine($"Is {Scarlet.FullName} a 7th grade XYZ student ? {sample.WhatIsPersonWithTuple(Scarlet, null)}");
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
