using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            double[][] jagged = new double[size][];

            for (int r = 0; r < jagged.Length; r++)
            {
                int[] rowNums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[r] = new double[rowNums.Length];

                for (int c = 0; c < jagged[r].Length; c++)
                {
                    jagged[r][c] = rowNums[c];
                }
            }

            for (int i = 0; i < jagged.Length - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                    }
                    for (int k = 0; k < jagged[i + 1].Length; k++)
                    {
                        jagged[i + 1][k] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] /= 2;
                    }
                    for (int k = 0; k < jagged[i + 1].Length; k++)
                    {
                        jagged[i + 1][k] /= 2;

                    }
                }
            }

            string text = Console.ReadLine();

            while (text != "End")
            {
                string[] command = text
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[2]) >= 0 &&
                        int.Parse(command[1]) < jagged.Length && int.Parse(command[2]) < jagged[int.Parse(command[1])].Length)
                    {
                        jagged[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                    }
                }
                else
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[2]) >= 0 &&
                        int.Parse(command[1]) < jagged.Length && int.Parse(command[2]) < jagged[int.Parse(command[1])].Length)
                    {
                        jagged[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                    }
                }

                text = Console.ReadLine();
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }
    }
}
