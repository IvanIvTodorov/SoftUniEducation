using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioactiveMutantVampBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[size[0], size[1]];

            List<int> bunnies = new List<int>();
            int[] player = new int[2];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] rowSymbols = Console.ReadLine().ToCharArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowSymbols[c];

                    if (matrix[r,c] == 'B')
                    {
                        bunnies.Add(r);
                        bunnies.Add(c);
                    }
                    if (matrix[r, c] == 'P')
                    {
                        player[0] = r;
                        player[1] = c;
                        matrix[r, c] = '.';
                    }
                }
            }

             char[] direction = Console.ReadLine().ToCharArray();

            string isOut = string.Empty;
            int i = 0;

            while (isOut != "true" || isOut != "false")
            {
                while (bunnies.Count != 0)
                {
                    int row = bunnies[0];
                    int col = bunnies[1];

                    if (row + 1 < matrix.GetLength(0))
                    {
                        matrix[row + 1, col] = 'B';
                    }
                    if (row - 1 >= 0)
                    {
                        matrix[row - 1, col] = 'B';
                    }
                    if (col + 1 < matrix.GetLength(1))
                    {
                        matrix[row, col + 1] = 'B';
                    }
                    if (col - 1 >= 0)
                    {
                        matrix[row, col - 1] = 'B';
                    }


                    bunnies.RemoveAt(0);
                    bunnies.RemoveAt(0);
                }

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        if (matrix[r,c] == 'B')
                        {
                            bunnies.Add(r);
                            bunnies.Add(c);
                        }
                    }
                }

                if (direction[i] == 'R')
                {
                    player[1] += 1;
                
                    if (player[0] >= matrix.GetLength(0) || player[0] < 0 || 
                        player[1] < 0 || player[1] >= matrix.GetLength(1))
                    {
                        isOut = "true";
                        player[1] -= 1;
                        break;
                    }
                    else if (matrix[player[0], player[1]] == 'B')
                    {
                        isOut = "false";
                        break;
                    }
                }
                else if (direction[i] == 'L')
                {
                    player[1] -= 1;

                    if (player[0] >= matrix.GetLength(0) || player[0] < 0 ||
                        player[1] < 0 || player[1] >= matrix.GetLength(1))
                    {
                        isOut = "true";
                        player[1] += 1;
                        break;
                    }
                    else if (matrix[player[0], player[1]] == 'B')
                    {
                        isOut = "false";
                        break;
                    }
                }
                else if (direction[i] == 'U')
                {
                    player[0] -= 1;

                    if (player[0] >= matrix.GetLength(0) || player[0] < 0 ||
                        player[1] < 0 || player[1] >= matrix.GetLength(1))
                    {
                        isOut = "true";
                        player[0] += 1;
                        break;
                    }
                    else if (matrix[player[0], player[1]] == 'B')
                    {
                        isOut = "false";
                        break;
                    }
                }
                else if (direction[i] == 'D')
                {
                    player[0] += 1;

                    if (player[0] >= matrix.GetLength(0) || player[0] < 0 ||
                        player[1] < 0 || player[1] >= matrix.GetLength(1))
                    {
                        isOut = "true";
                        player[0] -= 1;
                        break;
                    }
                    else if (matrix[player[0], player[1]] == 'B')
                    {
                        isOut = "false";
                        break;
                    }
                }
                i++;
            }

            StringBuilder output = new StringBuilder();
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    output.Append(matrix[r, c].ToString());
                }
                output.AppendLine();
            }

            Console.WriteLine(output.ToString().Trim());

            if (isOut == "true")
            {
                Console.WriteLine($"won: {player[0]} {player[1]}");
            }
            else if (isOut == "false")
            {
                Console.WriteLine($"dead: {player[0]} {player[1]}");
            }
        }
    }
}
