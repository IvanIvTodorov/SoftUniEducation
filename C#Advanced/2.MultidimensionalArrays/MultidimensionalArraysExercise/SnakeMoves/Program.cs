using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            string[,] matrix = new string[size[0], size[1]];
            int count = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                if (r % 2 == 0)
                {
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        if (count == snake.Length)
                        {
                            count = 0;
                        }
                        matrix[r, c] = snake[count].ToString();
                        count++;
                    }
                }
                else
                {
                    for (int c = matrix.GetLength(1) - 1; c >= 0; c--)
                    {
                        if (count == snake.Length)
                        {
                            count = 0;
                        }
                        matrix[r, c] = snake[count].ToString();
                        count++;
                    }
                }
                
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string current = string.Empty;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    current += matrix[row, col];
                }
                Console.WriteLine(current);
            }
        }
    }
}
