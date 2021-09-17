using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col  < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnNumbers[col];
                }
            }
            
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                int sumColumns = 0;

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    sumColumns += matrix[r, c];
                }

                Console.WriteLine(sumColumns);
            }
        }
    }
}
