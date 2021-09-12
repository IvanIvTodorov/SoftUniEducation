using System;
using System.Collections.Generic;
using System.Linq;

namespace MobaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = new string[] { "->", " vs " };

            List<Player> players = new List<Player>();
            while (input != "Season end")
            {
                string[] text = input.Split(split, StringSplitOptions.RemoveEmptyEntries);

                if (text.Length > 2)
                {
                    if (!players.Any(n => n.Name == text[0]))
                    {
                        Player player = new Player(text[0]);

                        player.Skills.Add(text[1], int.Parse(text[2]));

                        players.Add(player);
                    }
                    else
                    {
                        int index = players.FindIndex(n => n.Name == text[0]);

                        if (!players[index].Skills.ContainsKey(text[1]))
                        {
                            players[index].Skills.Add(text[1], int.Parse(text[2]));
                        }
                        else
                        {
                            if (players[index].Skills[text[1]] < int.Parse(text[2]))
                            {
                                players[index].Skills[text[1]] = int.Parse(text[2]);
                            }
                        }
                    }
                }
                else
                {
                    if (players.Any(n => n.Name.Contains(text[0])) && players.Any(n => n.Name.Contains(text[1])))
                    {
                        int first = players.FindIndex(n => n.Name.Contains(text[0]));
                        int second = players.FindIndex(n => n.Name.Contains(text[1]));
                        bool contains = false;
                        foreach (var item in players.Where(n => n.Name.Contains(text[0])))
                        {
                            foreach (var skill in item.Skills)
                            {
                                if (players[second].Skills.ContainsKey(skill.Key))
                                {
                                    contains = true;
                                    break;
                                }
                            }
                        }
                        if (contains)
                        {
                            int firstPoints = players[first].Skills.Sum(n => n.Value);
                            int secondPoints = players[second].Skills.Sum(n => n.Value);

                            int index = 0;
                            if (firstPoints > secondPoints)
                            {
                                index = players.FindIndex(n => n.Name.Contains(text[1]));
                            }
                            else if (secondPoints > firstPoints)
                            {
                                index = players.FindIndex(n => n.Name.Contains(text[0]));

                            }
                            players.Remove(players[index]);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in players.OrderByDescending(n => n.Skills.Values.Sum()).ThenBy(n => n.Name))
            {
                Console.WriteLine($"{item.Name.Trim()}: {item.Skills.Values.Sum()} skill");

                foreach (var skill in item.Skills.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
                {

                    Console.WriteLine($"-{skill.Key}<::> {skill.Value}");

                }
            }
        }
    }
    class Player
    {
        public Player(string name)
        {
            Name = name;
            Skills = new Dictionary<string, int>();
        }
        public string Name { get; set; }
        public Dictionary<string, int> Skills { get; set; }

    }
}
