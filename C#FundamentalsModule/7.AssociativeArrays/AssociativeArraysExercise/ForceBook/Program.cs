using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                string[] split = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (split.Contains("|"))
                {
                    string[] text = input.Split(" | ");
                    if (!teams.ContainsKey(text[0]))
                    {                    
                        if (!teams.Any(n => n.Value.Contains(text[1])))
                        {
                            teams.Add(text[0], new List<string>() { text[1] });
                        }
                    }
                    else
                    {
                        if (!teams[text[0]].Contains(text[1]))
                        {
                            teams[text[0]].Add(text[1]);
                        }
                    }
                }
                else
                {
                    string[] text = input.Split(" -> ");

                    foreach (var item in teams)
                    {
                        if (item.Value.Contains(text[0]))
                        {
                            item.Value.Remove(text[0]);
                        }
                    }


                    if (!teams.ContainsKey(text[1]))
                    {
                        teams.Add(text[1], new List<string>() { text[0] });
                    }
                    else
                    {
                        teams[text[1]].Add(text[0]);
                    }

                    Console.WriteLine($"{text[0]} joins the {text[1]} side!");
                }

                input = Console.ReadLine();
            }

            foreach (var item in teams.OrderByDescending(n => n.Value.Count()).ThenBy(n => n.Key).Where(n => n.Value.Count != 0))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var person in item.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"! {person}");
                }
            }
        }
    }
}
