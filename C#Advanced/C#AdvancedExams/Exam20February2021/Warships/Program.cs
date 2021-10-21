using System;
using System.Collections.Generic;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());

            List<string> input = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[,] field = new string[size, size];
            int firstCount = 0;
            int secondCount = 0;
            int AllShips = 0;
            int sum = 0;

            for (int r = 0; r < field.GetLength(0); r++)
            {
                string[] rowInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int c = 0; c < field.GetLength(1); c++)
                {
                    field[r, c] = rowInput[c];

                    if (field[r, c] == "<" || field[r, c] == ">")
                    {
                        AllShips++;
                    }
                }
            }

            for (int i = 0; i < input.Count; i++)
            {
                int[] split = input[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int row = split[0];
                int col = split[1];

                try
                {

                    if (field[row, col] == ">")
                    {
                        field[row, col] = "X";
                    }
                    else if (field[row, col] == "<")
                    {
                        field[row, col] = "X";
                    }
                    else if (field[row, col] == "#")
                    {
                        HitMine(field, ref sum, row, col);
                        field[row, col] = "*";
                    }

                    if (!PlayersCount(field, ref firstCount, ref secondCount))
                    {
                        sum = SinkedShips(field,sum);
                        if (firstCount == 0)
                        {                          
                            Console.WriteLine($"Player Two has won the game! {sum} ships have been sunk in the battle.");
                            Environment.Exit(0);
                        }
                        else if (secondCount == 0)
                        {
                            Console.WriteLine($"Player One has won the game! {sum} ships have been sunk in the battle.");
                            Environment.Exit(0);
                        }
                    }

                }
                catch (IndexOutOfRangeException)
                {

                }

            }

            Console.WriteLine($"It's a draw! Player One has {firstCount} ships left. Player Two has {secondCount} ships left.");

        }
        private static int SinkedShips(string[,] field, int sum)
        {
            for (int r = 0; r < field.GetLength(0); r++)
            {
                for (int c = 0; c < field.GetLength(1); c++)
                {
                    if (field[r, c] == "X")
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }
        private static bool PlayersCount(string[,] field, ref int firstCount, ref int secondCount)
        {
            firstCount = 0;
            secondCount = 0;

            for (int r = 0; r < field.GetLength(0); r++)
            {
                for (int c = 0; c < field.GetLength(1); c++)
                {
                    if (field[r, c] == ">")
                    {
                        secondCount++;
                    }
                    else if (field[r, c] == "<")
                    {
                        firstCount++;
                    }
                }
            }

            if (firstCount > 0 && secondCount > 0)
            {
                return true;
            }
            return false;
        }


        private static void HitMine(string[,] field, ref int sum, int row, int col)
        {
            for (int j = row - 1; j <= row + 1; j++)
            {
                for (int k = col - 1; k <= col + 1; k++)
                {
                    try
                    {
                        if (field[j, k] == ">")
                        {
                            field[j, k] = "X";
                        }
                        else if (field[j, k] == "<")
                        {
                            field[j, k] = "X";
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }
            }
        }

    }
}
