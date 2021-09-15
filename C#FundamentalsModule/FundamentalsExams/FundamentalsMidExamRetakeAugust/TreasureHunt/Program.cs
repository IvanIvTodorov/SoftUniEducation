using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            string text = Console.ReadLine();

            while (text != "Yohoho!")
            {

                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Loot")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        if (!items.Contains(command[i]))
                        {
                            items.Insert(0, command[i]);
                        }
                    }
                }
                else if (command[0] == "Drop")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= items.Count - 1)
                    {
                        string element = items[int.Parse(command[1])];
                        items.RemoveAt(int.Parse(command[1]));
                        items.Add(element);
                    }
                }
                else if (command[0] == "Steal")
                {
                    if (int.Parse(command[1]) >= items.Count)
                    {
                        Console.WriteLine(string.Join(", ", items));
                        items.Clear();
                    }
                    else
                    {
                        int remove = int.Parse(command[1]);
                        int count = 0;
                        for (int i = items.Count - remove; i <= items.Count - 1; i++)
                        {
                            count++;
                                                   
                            if (count == remove)
                            {
                                Console.WriteLine($"{items[i]}");
                                items.RemoveRange(items.Count - remove, remove);
                                
                                break;
                            }
                            Console.Write($"{items[i]}, ");
                        }
                    }
                }

                text = Console.ReadLine();
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double count = 0;
                foreach (var item in items)
                {
                    count += item.Length;
                }

                Console.WriteLine($"Average treasure gain: {count / items.Count:F2} pirate credits.");
            }
        }
    }
}
