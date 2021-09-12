using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Dragon> dragons = new List<Dragon>();
            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (text[2] == "null")
                {
                    text[2] = "45";
                }
                if (text[3] == "null")
                {
                    text[3] = "250";
                }
                if (text[4] == "null")
                {
                    text[4] = "10";
                }

                if (!dragons.Any(n => n.Color.Contains(text[0])))
                {
                    Dragon dragon = new Dragon(text[0]);

                    dragon.Stats.Add(new DragonStat(text[1], int.Parse(text[2]), int.Parse(text[3]), int.Parse(text[4])));

                    dragons.Add(dragon);
                }
                else
                {
                    int index = dragons.FindIndex(n => n.Color.Contains(text[0]));

                    if (dragons.Any(n => n.Stats.Any(n => n.Name.Contains(text[1]))))
                    {

                        dragons[index].Stats.RemoveAll(n => n.Name == text[1]);
                    }

                    dragons[index].Stats.Add(new DragonStat(text[1], int.Parse(text[2]), int.Parse(text[3]), int.Parse(text[4])));
                }
            }
            StringBuilder output = new StringBuilder();

            foreach (var item in dragons)
            {
                output.AppendLine($"{item.Color}::({item.Stats.Average(n => n.Damage):F2}" +
                                $"/{item.Stats.Average(n => n.Health):F2}" +
                                $"/{item.Stats.Average(n => n.Armor):F2})");
                foreach (var dragon in item.Stats.OrderBy(n => n.Name))
                {
                    output.AppendLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
            Console.WriteLine(output.ToString().Trim());
        }
    }
    class Dragon
    {
        public Dragon(string color)
        {
            Color = color;
            Stats = new List<DragonStat>();
        }
        public string Color { get; set; }
        public List<DragonStat> Stats { get; set; }

    }
    class DragonStat
    {
        public DragonStat(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

    }
}
