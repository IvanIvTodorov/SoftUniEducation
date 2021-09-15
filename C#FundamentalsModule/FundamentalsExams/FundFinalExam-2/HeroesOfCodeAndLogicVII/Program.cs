using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Hero hero = new Hero();

                if (int.Parse(input[1]) > 100)
                {
                    hero.HP = 100;
                }
                else
                {
                    hero.HP = int.Parse(input[1]);
                }
                if (int.Parse(input[2]) > 200)
                {
                    hero.MP = 200;
                }
                else
                {
                    hero.MP = int.Parse(input[2]);
                }

                heroes.Add(input[0], hero); 
            }

            string text = Console.ReadLine();

            while (text != "End")
            {
                string[] command = text.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "CastSpell")
                {
                    if (heroes[command[1]].MP >= int.Parse(command[2]))
                    {
                        heroes[command[1]].MP -= int.Parse(command[2]);
                        Console.WriteLine($"{command[1]} has successfully cast {command[3]} and now has {heroes[command[1]].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} does not have enough MP to cast {command[3]}!");
                    }
                }
                else if (command[0] == "TakeDamage")
                {
                    if (heroes[command[1]].HP > int.Parse(command[2]))
                    {
                        heroes[command[1]].HP -= int.Parse(command[2]);
                        Console.WriteLine($"{command[1]} was hit for {command[2]} HP by {command[3]} and now has {heroes[command[1]].HP} HP left!");
                    }
                    else
                    {
                        heroes.Remove(command[1]);
                        Console.WriteLine($"{command[1]} has been killed by {command[3]}!");
                    }
                }
                else if (command[0] == "Recharge")
                {
                    if (heroes[command[1]].MP + int.Parse(command[2]) > 200)
                    {
                        Console.WriteLine($"{command[1]} recharged for {200 - heroes[command[1]].MP} MP!");
                        heroes[command[1]].MP = 200;
                    }
                    else
                    {
                        heroes[command[1]].MP += int.Parse(command[2]);
                        Console.WriteLine($"{command[1]} recharged for {int.Parse(command[2])} MP!");
                    }
                }
                else if (command[0] == "Heal")
                {
                    if (heroes[command[1]].HP + int.Parse(command[2]) > 100)
                    {
                        Console.WriteLine($"{command[1]} healed for {100 - heroes[command[1]].HP} HP!");
                        heroes[command[1]].HP = 100;
                    }
                    else
                    {
                        heroes[command[1]].HP += int.Parse(command[2]);
                        Console.WriteLine($"{command[1]} healed for {int.Parse(command[2])} HP!");
                    }
                }
                text = Console.ReadLine();
            }

            foreach (var item in heroes.OrderByDescending(n => n.Value.HP).ThenBy(n => n.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value.HP}");
                Console.WriteLine($"  MP: {item.Value.MP}");
            }
        }
    }
    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
