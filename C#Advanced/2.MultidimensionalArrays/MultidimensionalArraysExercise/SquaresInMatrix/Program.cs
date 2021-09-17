using System;
using System.Linq;

namespace SquaresInMatrix
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

            int count = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] rowSymbols = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = rowSymbols[col];
                }
            }

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {                
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {                   
                    if (matrix[r, c] == matrix[r, c + 1] &&
                        matrix[r, c] == matrix[r + 1, c] && 
                        matrix[r, c] == matrix[r + 1, c + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
