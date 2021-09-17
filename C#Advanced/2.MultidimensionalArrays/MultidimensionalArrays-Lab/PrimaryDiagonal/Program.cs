using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int sumDiagonal = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] columnNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = columnNumbers[c];

                    if (r == c)
                    {
                        sumDiagonal += matrix[r, c];
                    }
                }
            }

            Console.WriteLine(sumDiagonal);
        }
    }
}
