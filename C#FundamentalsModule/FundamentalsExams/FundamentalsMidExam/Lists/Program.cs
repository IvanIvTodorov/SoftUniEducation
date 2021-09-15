using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int index = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int breakLeft = 0;
            int breakRight = 0;
            for (int i = index + 1; i < input.Count; i++)
            {
                if (command == "cheap")
                {
                    if (input[i] < input[index])
                    {
                        breakRight += input[i];
                    }
                }
                else
                {
                    if (input[i] >= input[index])
                    {
                        breakRight += input[i];
                    }
                }

            }
            for (int i = index - 1; i >= 0; i--)
            {
                if (command == "cheap")
                {
                    if (input[i] < input[index])
                    {
                        breakLeft += input[i];
                    }
                }
                else
                {
                    if (input[i] >= input[index])
                    {
                        breakLeft += input[i];
                    }
                }
            }
            if (breakLeft >= breakRight)
            {
                Console.WriteLine($"Left - {breakLeft}");
            }
            else
            {
                Console.WriteLine($"Right - {breakRight}");
            }
        }
    }
}
