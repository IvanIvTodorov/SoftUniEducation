using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int firstDiagonal = 0;
            int secondDiagonal = 0;

            int count = matrix.GetLength(1) - 1;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] rowNums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowNums[c];

                    if (r == c)
                    {
                        firstDiagonal += matrix[r, c];
                    }
                    if (c == count)
                    {
                        secondDiagonal += matrix[r, c];
                        count--;
                    }
                }
            }

            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
        }
    }
}
