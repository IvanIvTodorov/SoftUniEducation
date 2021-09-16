using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bottlesArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int wasted = 0;

            Stack<int> bottles = new Stack<int>(bottlesArr);
            Queue<int> cups = new Queue<int>(cupsArr);

            while (cups.Count != 0)
            {
                int cup = cups.Peek();
                int bottle = bottles.Peek();

                if (cup <= bottle)
                {
                    cups.Dequeue();
                    bottles.Pop();
                    
                    wasted += bottle - cup;
                }
                else
                {
                    while (cup > 0)
                    {
                        cup -= bottle;
                        bottles.Pop();

                        if (bottles.Count == 0)
                        {
                            break;
                        }

                        bottle = bottles.Peek();
                    }

                    cups.Dequeue();

                    wasted += Math.Abs(cup);
                }

                if (bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                    Console.WriteLine($"Wasted litters of water: {wasted}");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            Console.WriteLine($"Wasted litters of water: {wasted}");
        }
    }
}
