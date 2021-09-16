using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine().ToLower();

            Stack<int> colection = new Stack<int>(numbers);
            while (text != "end")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "add")
                {
                    colection.Push(int.Parse(command[1]));
                    colection.Push(int.Parse(command[2]));
                }
                else
                {
                    if (int.Parse(command[1]) <= colection.Count())
                    {

                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {

                            colection.Pop();
                        }
                    }
                }
                text = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {colection.Sum()}");
        }
    }
}
