using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirate = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> war = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int health = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            while (text != "Retire")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Fire")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < war.Count)
                    {
                        war[int.Parse(command[1])] -= int.Parse(command[2]);
                        if (war[int.Parse(command[1])] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            Environment.Exit(0);
                        }
                    }
                }
                else if (command[0] == "Defend")
                {
                    if ((int.Parse(command[1]) >= 0 && int.Parse(command[1]) < pirate.Count) &&
                        (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < pirate.Count))
                    {
                        for (int i = int.Parse(command[1]); i <= int.Parse(command[2]); i++)
                        {
                            pirate[i] -= int.Parse(command[3]);
                            if (pirate[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                Environment.Exit(0);
                            }
                        }                 
                    }
                }
                else if (command[0] == "Repair")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < pirate.Count)
                    {
                        pirate[int.Parse(command[1])] += int.Parse(command[2]);
                        if (pirate[int.Parse(command[1])] > health)
                        {
                            pirate[int.Parse(command[1])] = health;
                        }
                    }
                }
                else if (command[0] == "Status")
                {
                    int count = 0;
                    foreach (var item in pirate)
                    {
                        if (item < health * 0.20)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }


                text = Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirate.Sum()}");
            Console.WriteLine($"Warship status: {war.Sum()}");
        }
    }
}
