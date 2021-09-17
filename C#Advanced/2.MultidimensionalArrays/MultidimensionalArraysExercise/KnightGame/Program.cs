using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            if (size == 2)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }

            string[,] matrix = new string[size, size];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] rowSymbols = Console.ReadLine()
                    .ToCharArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowSymbols[c].ToString();
                }
            }

            int count = 0;
            int maxRemove = 0;
            while (true)
            {
                int remove = 0;               
                int[] position = new int[2];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == "K")
                        {
                            if (row - 1 >= 0 && col - 2 >= 0)
                            {
                                if (matrix[row - 1, col - 2] == "K")
                                {
                                    remove++;
                                }
                            }
                            if (row - 1 >= 0 && col + 2 < matrix.GetLength(1))
                            {
                                if (matrix[row - 1, col + 2] == "K")
                                {
                                    remove++;
                                }
                            }
                            if (row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (matrix[row - 2, col - 1] == "K")
                                {
                                    remove++;
                                }
                            }
                            if (row - 2 >= 0 && col + 1 < matrix.GetLength(1))
                            {
                                if (matrix[row - 2, col + 1] == "K")
                                {
                                    remove++;
                                }
                            }
                            if (row + 1 < matrix.GetLength(0) && col - 2 >= 0)
                            {
                                if (matrix[row + 1, col - 2] == "K")
                                {
                                    remove++;
                                }
                            }
                            if (row + 1 < matrix.GetLength(0) && col + 2 < matrix.GetLength(1))
                            {
                                if (matrix[row + 1, col + 2] == "K")
                                {
                                    remove++;
                                }
                            }
                            if (row + 2 < matrix.GetLength(0) && col - 1 >= 0)
                            {
                                if (matrix[row + 2, col - 1] == "K")
                                {
                                    remove++;
                                }
                            }
                            if (row + 2 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
                            {
                                if (matrix[row + 2, col + 1] == "K")
                                {
                                    remove++;
                                }
                            }

                            if (remove > maxRemove)
                            {

                                maxRemove = remove;                              
                                position[0] = row;
                                position[1] = col;
                            }
                            remove = 0;
                        }
                    }
                }
                if (maxRemove == 0)
                {
                    break;
                }
                else
                {
                    matrix[position[0], position[1]] = "0";
                    count++;
                    maxRemove = 0;
                }
            }
            Console.WriteLine(count);
        }

    }
}

