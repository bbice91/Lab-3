using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static void Main()
        {
            int Input;
            string Decision;
            string Name;
            Console.WriteLine("Greetings! What is your name?");
            Name = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Name}, enter a number between 1 and 100:");
                Input = Convert.ToInt32(Console.ReadLine());
                if (Input % 2 != 0)
                {
                    if (Input > 60)
                    {
                        Console.WriteLine($"{Name}, {Input} and Odd");
                    }
                }
                else if (2 <= Input && Input <= 25)
                {
                    Console.WriteLine($"{Name}, Even and less than 25");
                }
                else if (Input is >= 26 and <= 60)
                {
                    Console.WriteLine($"{Name}, Even");
                }
                else if (Input > 60)
                {
                    Console.WriteLine($"{Name}, {Input} and Even");
                }

                Console.WriteLine($"Continue {Name}? (y/n)");
                Decision = Console.ReadLine().ToLower();
                if (Decision == "n")
                {
                    Console.WriteLine($"Bye {Name}!");
                    Environment.Exit(0);
                }

            }

        }

    }

}