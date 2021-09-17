using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = ReadFromConsole();

            int[,] matrix = new int[size[0], size[1]];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] rowNums = ReadFromConsole();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowNums[c];
                }
            }

            int curSum = 0;
            int maxSum = 0;
            int[] index = new int[2];
            
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    curSum += matrix[row, col];
                    curSum += matrix[row, col + 1];
                    curSum += matrix[row, col + 2];
                    curSum += matrix[row + 1, col];
                    curSum += matrix[row + 1, col + 1];
                    curSum += matrix[row + 1, col + 2];
                    curSum += matrix[row + 2, col];
                    curSum += matrix[row + 2, col + 1];
                    curSum += matrix[row + 2, col + 2];

                    if (curSum > maxSum)
                    {
                        maxSum = curSum;
                        index[0] = row;
                        index[1] = col;
                    }
                    curSum = 0;
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[index[0], index[1]]} {matrix[index[0], index[1] + 1]} {matrix[index[0], index[1] + 2]}");
            Console.WriteLine($"{matrix[index[0] + 1, index[1]]} {matrix[index[0] + 1, index[1] + 1]} {matrix[index[0] + 1, index[1] + 2]}");
            Console.WriteLine($"{matrix[index[0] + 2, index[1]]} {matrix[index[0] + 2, index[1] + 1]} {matrix[index[0] + 2, index[1] + 2]}");
          
        }

        private static int[] ReadFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
