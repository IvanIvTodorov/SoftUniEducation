using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .ToLower()
                .Split();

            Dictionary<string, int> junks = new Dictionary<string, int>();
            Dictionary<string, int> items = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0},
            };

            int current = 0;
            while (true)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        current = int.Parse(text[i]);
                    }
                    else
                    {
                        if (items.ContainsKey(text[i]))
                        {
                            items[text[i]] += current;
                        }
                        else if (!junks.ContainsKey(text[i]))
                        {
                            junks.Add(text[i], current);
                        }
                        else
                        {
                            junks[text[i]] += current;
                        }

                        if (items.Any(n => n.Value >= 250))
                        {
                            if (items["shards"] >= 250)
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                items["shards"] -= 250;

                            }
                            else if (items["fragments"] >= 250)
                            {
                                Console.WriteLine("Valanyr obtained!");
                                items["fragments"] -= 250;

                            }
                            else
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                items["motes"] -= 250;
                            }
                            foreach (var item in items.OrderBy(n => n.Key).OrderByDescending(n => n.Value))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            foreach (var item in junks.OrderBy(n => n.Key))
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            Environment.Exit(0);
                        }
                    }
                }
                text = Console.ReadLine()
                .ToLower()
                .Split();
            }
        }
    }
}
