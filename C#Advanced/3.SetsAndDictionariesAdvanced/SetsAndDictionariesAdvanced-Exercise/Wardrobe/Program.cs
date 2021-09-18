using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string[] itemToAdd = command[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < itemToAdd.Length; j++)
                {

                    if (clothes.ContainsKey(command[0]))
                    {
                        if (clothes[command[0]].ContainsKey(itemToAdd[j]))
                        {
                            clothes[command[0]][itemToAdd[j]]++; 
                        }
                        else
                        {
                            clothes[command[0]].Add(itemToAdd[j], 1);
                        }
                    }
                    else
                    {
                        clothes.Add(command[0], new Dictionary<string, int>());
                        clothes[command[0]].Add(itemToAdd[j], 1);
                    }
                }
            }
            string[] find = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var piece in color.Value)
                {
                    if (find[0] == color.Key && find[1] == piece.Key)
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value}");
                    }
                }
            }
        }
    }
}
