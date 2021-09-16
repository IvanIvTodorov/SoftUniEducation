using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songs = new Queue<string>(input);

            while (songs.Count != 0)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string current = string.Empty;
                
                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        current += command[i] + " ";
                    }
                    current = current.Trim();
                    if (songs.Contains(current))
                    {
                        Console.WriteLine($"{current} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(current);
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
