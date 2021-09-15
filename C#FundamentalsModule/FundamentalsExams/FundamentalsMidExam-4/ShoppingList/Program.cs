using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string text = Console.ReadLine();

            while (text != "Go Shopping!")
            {
                string[] command = text
                    .ToString()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Urgent")
                {
                    if (!input.Contains(command[1]))
                    {
                        input.Insert(0, command[1]);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    if (input.Contains(command[1]))
                    {
                        input.Remove(command[1]);
                    }
                }
                else if (command[0] == "Correct")
                {
                    if (input.Contains(command[1]))
                    {
                        int index = input.FindIndex(n => n == command[1]);
                        input.Remove(command[1]);
                        input.Insert(index, command[2]);

                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (input.Contains(command[1]))
                    {
                        input.Remove(command[1]);
                        input.Add(command[1]);
                    }
                }
                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
