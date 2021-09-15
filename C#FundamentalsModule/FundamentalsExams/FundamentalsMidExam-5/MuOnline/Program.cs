using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] command = input[i]
                    .ToString()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "potion")
                {
                    if (health + int.Parse(command[1]) >= 100)
                    {
                        int add = 100 - health;
                        health = 100;
                        Console.WriteLine($"You healed for {add} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        health += int.Parse(command[1]);
                        Console.WriteLine($"You healed for {command[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (command[0] == "chest")
                {
                    bitcoins += int.Parse(command[1]);
                    Console.WriteLine($"You found {command[1]} bitcoins.");
                }
                else
                {
                    health -= int.Parse(command[1]);
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {++i}");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
