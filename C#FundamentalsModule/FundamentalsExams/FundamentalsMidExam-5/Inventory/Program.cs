using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "Craft!")
            {
                string[] split = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (split[0] == "Collect")
                {
                    if (!input.Contains(split[1]))
                    {
                        input.Add(split[1]);
                    }
                }
                else if (split[0] == "Drop")
                {
                    if (input.Contains(split[1]))
                    {
                        input.Remove(split[1]);
                    }
                }
                else if (split[0] == "Combine Items")
                {
                    string[] splitTwo = split[1]
                        .ToString()
                        .Split(":", StringSplitOptions.RemoveEmptyEntries);

                    if (input.Contains(splitTwo[0]))
                    {
                       int index = input.FindIndex(n => n == splitTwo[0]);

                        input.Insert(++index, splitTwo[1]);
                    }
                }
                else if (split[0] == "Renew")
                {
                    if (input.Contains(split[1]))
                    {
                        input.Remove(split[1]);
                        input.Add(split[1]);
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
