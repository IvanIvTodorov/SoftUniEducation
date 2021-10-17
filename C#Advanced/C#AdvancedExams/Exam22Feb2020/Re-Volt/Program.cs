using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string[,] field = new string[size, size];
            int[] playerPosition = null;

            for (int r = 0; r < field.GetLength(0); r++)
            {
                string rowInput = Console.ReadLine();
                for (int c = 0; c < field.GetLength(1); c++)
                {
                    field[r, c] = rowInput[c].ToString();

                    if (field[r, c] == "f")
                    {
                        playerPosition = new int[] { r, c };
                        field[r, c] = "-";
                    }
                }
            }
            int row = playerPosition[0];
            int col = playerPosition[1];
            string command = string.Empty;
            const int MOVE = 1;

            for (int i = 0; i < n; i++)
            {
                try
                {
                    if (field[row, col] == "B")
                    {
                        if (command == "up")
                        {
                            row++;
                        }
                        else if (command == "left")
                        {
                            col--;
                        }
                        else if (command == "right")
                        {
                            col++;
                        }
                        else if (command == "down")
                        {
                            row--;
                        }
                    }
                    else if (field[row, col] == "T")
                    {
                        if (command == "up")
                        {
                            row = 0;
                        }
                        else if (command == "left")
                        {
                            col = 0;
                        }
                        else if (command == "right")
                        {
                            col = field.GetLength(1) - MOVE;
                        }
                        else if (command == "down")
                        {
                            row = field.GetLength(0) - MOVE;
                        }
                    }
                    else if (field[row, col] == "F")
                    {
                        field[row, col] = "f";
                        StopTheProgram(field);
                    }
                    command = Console.ReadLine();
                    
                    if (command == "up")
                    {
                        row -= MOVE;
                        if (field[row, col] == "B" || field[row, col] == "T" || field[row, col] == "F")
                        {
                            if (field[row, col] == "T")
                            {
                                row++;
                            }
                            else if (field[row, col] == "F")
                            {
                                field[row, col] = "f";
                                StopTheProgram(field);
                            }
                            else
                            {
                                row -= MOVE;
                                while (field[col, row] == "B")
                                {
                                    row -= MOVE;
                                }
                            }
                        }
                    }
                    else if (command == "left")
                    {
                        col -= MOVE;
                        if (field[row, col] == "B" || field[row, col] == "T" || field[row, col] == "F")
                        {
                            if (field[row, col] == "T")
                            {
                                col++;
                            }
                            else if (field[row, col] == "F")
                            {
                                field[row, col] = "f";
                                StopTheProgram(field);
                            }
                            else
                            {
                                col -= MOVE;
                                while (field[col, row] == "B")
                                {
                                    col -= MOVE;
                                }
                            }
                        }
                    }
                    else if (command == "right")
                    {
                        col += MOVE;
                        if (field[row, col] == "B" || field[row, col] == "T" || field[row, col] == "F")
                        {
                            if (field[row, col] == "T")
                            {
                                col--;
                            }
                            else if (field[row, col] == "F")
                            {
                                field[row, col] = "f";
                                StopTheProgram(field);
                            }
                            else
                            {
                                col += MOVE;
                                while (field[col, row] == "B")
                                {
                                    col += MOVE;
                                }
                            }
                        }
                    }
                    else if (command == "down")
                    {
                        row += MOVE;
                        if (field[row, col] == "B" || field[row, col] == "T" || field[row, col] == "F")
                        {
                            if (field[row, col] == "T")
                            {
                                row--;
                            }
                            else if (field[row, col] == "F")
                            {
                                field[row, col] = "f";
                                StopTheProgram(field);
                            }
                            else
                            {
                                row += MOVE;
                                while (field[col, row] == "B")
                                {
                                    row += MOVE;
                                }
                            }
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    if (command == "up")
                    {
                        row = field.GetLength(0) - MOVE;
                    }
                    else if (command == "left")
                    {
                        col = field.GetLength(1) - MOVE;
                    }
                    else if (command == "right")
                    {
                        col = 0;
                    }
                    else if (command == "down")
                    {
                        row = 0;
                    }

                }

            }

            field[row, col] = "f";
            Console.WriteLine("Player lost!");
            for (int r = 0; r < field.GetLength(0); r++)
            {
                for (int c = 0; c < field.GetLength(1); c++)
                {
                    Console.Write(field[r, c]);
                }
                Console.WriteLine();
            }

        }

        private static void StopTheProgram(string[,] field)
        {
            Console.WriteLine("Player won!");
            for (int r = 0; r < field.GetLength(0); r++)
            {
                for (int c = 0; c < field.GetLength(1); c++)
                {
                    Console.Write(field[r, c]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }
    }
}
