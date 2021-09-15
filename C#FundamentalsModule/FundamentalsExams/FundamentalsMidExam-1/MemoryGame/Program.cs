using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            int moves = 0;
            while (command != "end")
            {
                int[] index = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                moves++;
                if (index[0] == index[1] || index[0] < 0 || index[0] > text.Count - 1 || index[1] < 0 || index[1] > text.Count - 1)
                {
                    int add = (text.Count) / 2;
                    text.Insert(add, $"-{moves}a");
                    text.Insert(add, $"-{moves}a");
                    
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (text[index[0]] != text[index[1]])
                {
                    Console.WriteLine("Try again!");
                }
                else
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {text[index[0]]}!");
                    string remove = text[index[0]];
                    text.Remove(remove);
                    text.Remove(remove);

                }

                if (text.Distinct().Count() == text.Count())
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    Environment.Exit(0);
                }


                command = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
