using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string text = Console.ReadLine();

            while (text != "Stop!")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Join")
                {
                    if (!input.Contains(command[1]))
                    {
                        input.Add(command[1]);
                    }
                }
                else if (command[0] == "Drop")
                {
                    if (input.Contains(command[1]))
                    {
                        input.Remove(command[1]);
                    }
                }
                else if (command[0] == "Replace")
                {
                    if (input.Contains(command[1]))
                    {
                        if (!input.Contains(command[2]))
                        {
                            int index = input.FindIndex(n => n == command[1]);
                            input[index] = command[2];
                        }
                    }
                }
                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
