using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[,] matrix = new int[number, number];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] rowNums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowNums[c];
                }
            }

            string[] splitters = new string[] { " ", "," };
            int[] input = Console.ReadLine()
                .Split(splitters, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> index = new Queue<int>(input);

            while (true)
            {
                int row = index.Dequeue();
                int col = index.Dequeue();
                if (matrix[row, col] > 0)
                {
                    for (int r = row - 1; r <= row + 1; r++)
                    {
                        for (int c = col - 1; c <= col + 1; c++)
                        {
                            if (r == row && c == col)
                            {

                                continue;
                            }
                            else
                            {
                                if (r < matrix.GetLength(0) && c < matrix.GetLength(1) &&
                                       r >= 0 && c >= 0)
                                {
                                    if (matrix[r, c] > 0)
                                    {
                                        matrix[r, c] -= matrix[row, col];
                                    }

                                }
                            }
                        }
                    }
                    matrix[row, col] = 0;
                }

                if (index.Count == 0)
                {
                    break;
                }
            }
            int sum = 0;
            int count = 0;
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    sum += item;
                    count++;
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
