using System;
using System.Collections.Generic;
using System.Linq;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = 8;

            string[,] field = new string[size, size];

            int whiteRow = 0;
            int whiteCol = 0;
            int blackRow = 0;
            int blackCol = 0;

            for (int r = 0; r < field.GetLength(0); r++)
            {
                string rowInput = Console.ReadLine();

                for (int c = 0; c < field.GetLength(1); c++)
                {
                    field[r, c] = rowInput[c].ToString();

                    if (field[r, c] == "w")
                    {
                        whiteRow = r;
                        whiteCol = c;
                    }
                    if (field[r, c] == "b")
                    {
                        blackRow = r;
                        blackCol = c;
                    }
                }
            }

            while (true)
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        try
                        {
                            if (i == 0 && field[whiteRow - 1, whiteCol - 1] == "b")
                            {
                                whiteCol--;
                                whiteRow--;
                                string current = string.Empty;
                                current = ChooseCol(whiteCol, current);
                                int row = 0;
                                row = ChooseRow(whiteRow, row);
                                string result = current + row;
                                Console.WriteLine($"Game over! White capture on {result}.");
                                Environment.Exit(0);
                            }
                            if (i == 1 && field[whiteRow - 1, whiteCol + 1] == "b")
                            {
                                whiteCol++;
                                whiteRow--;
                                string current = string.Empty;
                                current = ChooseCol(whiteCol, current);
                                int row = 0;
                                row = ChooseRow(whiteRow, row);
                                string result = current + row;
                                Console.WriteLine($"Game over! White capture on {result}.");
                                Environment.Exit(0);
                            }

                        }
                        catch (IndexOutOfRangeException)
                        {

                        }

                    }
                    if (whiteRow - 1 == 0)
                    {
                        whiteRow--;
                        string current = string.Empty;
                        current = ChooseCol(whiteCol, current);
                        int row = 0;
                        row = ChooseRow(whiteRow, row);
                        string result = current + row;
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {result}.");
                        Environment.Exit(0);
                    }

                    field[whiteRow, whiteCol] = "-";
                    whiteRow--;
                    field[whiteRow, whiteCol] = "w";
                    for (int i = 0; i < 2; i++)
                    {
                        try
                        {
                            if (i == 0 && field[blackRow + 1, blackCol - 1] == "w")
                            {
                                blackRow++;
                                blackCol--;
                                string current = string.Empty;
                                current = ChooseCol(blackCol, current);
                                int row = 0;
                                row = ChooseRow(blackRow, row);
                                string result = current + row;
                                Console.WriteLine($"Game over! Black capture on {result}.");
                                Environment.Exit(0);
                            }
                            if (i == 1 && field[blackRow + 1, blackCol + 1] == "w")
                            {
                                blackRow++;
                                blackCol++;
                                string current = string.Empty;
                                current = ChooseCol(blackCol, current);
                                int row = 0;
                                row = ChooseRow(blackRow, row);
                                string result = current + row;
                                Console.WriteLine($"Game over! Black capture on {result}.");
                                Environment.Exit(0);
                            }

                        }
                        catch (IndexOutOfRangeException)
                        {

                        }

                    }
                    if (blackRow + 1 == 7)
                    {
                        blackRow++;
                        string current = string.Empty;
                        current = ChooseCol(blackCol, current);
                        int row = 0;
                        row = ChooseRow(blackRow, row);
                        string result = current + row;
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {result}.");
                        Environment.Exit(0);
                    }
                    field[blackRow, blackCol] = "-";
                    blackRow++;
                    field[blackRow, blackCol] = "b";
                }
                catch (IndexOutOfRangeException)
                {

                }

            }

        }

        private static int ChooseRow(int current, int row)
        {
            if (current == 0)
            {
                row = 8;
            }
            else if (current == 1)
            {
                row = 7;
            }
            else if (current == 2)
            {
                row = 6;
            }
            else if (current == 3)
            {
                row = 5;
            }
            else if (current == 4)
            {

                row = 4;
            }
            else if (current == 5)
            {
                row = 3;
            }
            else if (current == 6)
            {
                row = 2;
            }
            else if (current == 7)
            {
                row = 1;
            }
            return row;
        }

        private static string ChooseCol(int col, string current)
        {
            if (col == 0)
            {
                current = "a";
            }
            else if (col == 1)
            {
                current = "b";

            }
            else if (col == 2)
            {
                current = "c";
            }
            else if (col == 3)
            {
                current = "d";
            }
            else if (col == 4)
            {
                current = "e";
            }
            else if (col == 5)
            {
                current = "f";
            }
            else if (col == 6)
            {
                current = "g";
            }
            else if (col == 7)
            {
                current = "h";
            }

            return current;
        }
    }
}
