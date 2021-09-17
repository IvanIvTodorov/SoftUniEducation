using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];

            Queue<string> commands = new Queue<string>(Console.ReadLine()
                                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                        .ToArray());
            int coalsInMatrix = 0;
            int[] start = new int[2];

            for (int r  = 0; r < matrix.GetLength(0); r++)
            {
                string[] rowSymbols = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowSymbols[c];

                    if (matrix[r,c] == "c")
                    {
                        coalsInMatrix++;
                    }
                    if (matrix[r, c] == "s")
                    {
                        start[0] = r;
                        start[1] = c;
                    }
                }
            }

            int coals = 0;
            while (commands.Count != 0)
            {
                string current = commands.Dequeue();

                if (current == "left")
                {
                    if (start[1] - 1 >= 0)
                    {
                        start[1] -= 1;
                    }
                }
                else if (current == "right")
                {
                    if (start[1] + 1 < matrix.GetLength(1))
                    {
                        start[1] += 1;
                    }
                }
                else if (current == "up")
                {
                    if (start[0] - 1 >= 0)
                    {
                        start[0] -= 1;
                    }
                }
                else if (current == "down")
                {
                    if (start[0] + 1 < matrix.GetLength(1))
                    {
                        start[0] += 1;
                    }
                }
                if (matrix[start[0], start[1]] == "c")
                {
                    coals++;
                    matrix[start[0], start[1]] = "*";
                    coalsInMatrix--;
                    if (coalsInMatrix == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({start[0]}, {start[1]})");
                        Environment.Exit(0);
                    }
                }
                else if (matrix[start[0], start[1]] == "e")
                {
                    Console.WriteLine($"Game over! ({start[0]}, {start[1]})");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine($"{coalsInMatrix} coals left. ({start[0]}, {start[1]})");
        }
    }
}
