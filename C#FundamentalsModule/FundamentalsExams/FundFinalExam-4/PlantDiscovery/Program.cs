using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                if (!plants.ContainsKey(text[0]))
                {
                    Plant plant = new Plant()
                    {
                        Rarity = int.Parse(text[1]),
                        Rating = new List<int>()
                    };
                    
                    plants.Add(text[0], plant);
                }
                else
                {
                    plants[text[0]].Rarity = int.Parse(text[1]);
                }
                
            }

            string input = Console.ReadLine();

            string[] splits = new string[] { " ", "-" };

            while (input != "Exhibition")
            {
                string[] command = input.Split(splits, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Rate:")
                {
                    if (plants.ContainsKey(command[1]))
                    {
                        plants[command[1]].Rating.Add(int.Parse(command[2]));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Update:")
                {
                    if (plants.ContainsKey(command[1]))
                    {
                        plants[command[1]].Rarity = int.Parse(command[2]);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Reset:")
                {
                    if (plants.ContainsKey(command[1]))
                    {
                        plants[command[1]].Rating.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                
                input = Console.ReadLine();
            }

            foreach (var item in plants)
            {
                if (item.Value.Rating.Count == 0)
                {
                    item.Value.Rating.Add(0);
                }
            }   
            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plants.OrderByDescending(n => n.Value.Rarity).ThenByDescending(n => n.Value.Rating.Average()))
            {             
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.Rating.Average():f2}");
            }
        }
    }

    class Plant
    {
        public List<int> Rating { get; set; }
        public int Rarity { get; set; }
    }
}
