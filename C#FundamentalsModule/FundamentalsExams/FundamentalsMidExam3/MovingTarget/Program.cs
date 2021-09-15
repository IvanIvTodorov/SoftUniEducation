using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            string text = Console.ReadLine();

            while (text != "End")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Shoot")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < targets.Count)
                    {
                        if (targets[int.Parse(command[1])] - int.Parse(command[2]) <= 0)
                        {
                            targets.RemoveAt(int.Parse(command[1]));
                        }
                        else
                        {
                            targets[int.Parse(command[1])] -= int.Parse(command[2]);
                        }
                    }
                }
                else if (command[0] == "Add")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < targets.Count)
                    {
                        targets.Insert(int.Parse(command[1]), int.Parse(command[2]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command[0] == "Strike")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < targets.Count)
                    {
                        if (int.Parse(command[1]) - int.Parse(command[2]) >= 0 && int.Parse(command[1]) + int.Parse(command[2]) < targets.Count)
                        {
                            targets.RemoveRange(int.Parse(command[1]) - int.Parse(command[2]), (int.Parse(command[2]) * 2) + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                text = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|",targets));
        }
    }
}
