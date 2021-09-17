using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string[] rowSymbols = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowSymbols[c];
                }
            }

            string text = Console.ReadLine();

            while (text != "END")
            {
                string[] command = text
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (command[0] == "swap" && command.Length == 5)
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[2]) >= 0 &&
                       int.Parse(command[1]) < size[0] && int.Parse(command[2]) < size[1])
                    {
                        if (int.Parse(command[3]) >= 0 && int.Parse(command[4]) >= 0 &&
                        int.Parse(command[3]) < size[0] && int.Parse(command[4]) < size[1])
                        {
                            string current = matrix[int.Parse(command[1]), int.Parse(command[2])];
                            matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
                            matrix[int.Parse(command[3]), int.Parse(command[4])] = current;

                            for (int r = 0; r < matrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < matrix.GetLength(1); c++)
                                {
                                    Console.Write($"{matrix[r,c]} ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                text = Console.ReadLine();
            }
        }
    }
}
