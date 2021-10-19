using System;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {

            int lives = int.Parse(Console.ReadLine());
            int rowSize = int.Parse(Console.ReadLine());

            string[][] field = new string[rowSize][];
            int[] playerPosition = null;
            for (int r = 0; r < rowSize; r++)
            {
                string rowInput = Console.ReadLine();
                    
                field[r] = new string[rowInput.Length];
                for (int c = 0; c < rowInput.Length; c++)
                {
                    field[r][c] = rowInput[c].ToString();

                    if (field[r][c] == "M")
                    {
                        playerPosition = new int[] { r, c };
                        field[r][c] = "-";
                    }
                }
            }

            int playerRow = playerPosition[0];
            int playerCol = playerPosition[1];
            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string direction = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                
                field[row][col] = "B";
                try
                {
                    Move(direction, ref playerRow, ref playerCol);
                    lives--;
                    if (field[playerRow][playerCol] == "B")
                    {
                        lives -= 2;

                        if (lives > 0)
                        {
                            field[playerRow][playerCol] = "-";
                        }
                    }
                    else if (field[playerRow][playerCol] == "P")
                    {
                        field[playerRow][playerCol] = "-";

                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                        PrintField(field);
                        StopTheProgram();
                    }

                    if (lives <= 0)
                    {
                        field[playerRow][playerCol] = "X";

                        Console.WriteLine($"Mario died at {playerRow};{playerCol}.");
                        PrintField(field);
                        StopTheProgram();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    ReturnPosition(direction, ref playerRow, ref playerCol);
                }

            }

        }

        private static void StopTheProgram()
        {
            Environment.Exit(0);
        }

        private static void PrintField(string[][] field)
        {
            for (int r = 0; r < field.GetLength(0); r++)
            {
                for (int c = 0; c < field[r].Length; c++)
                {
                    Console.Write(field[r][c]);
                }
                Console.WriteLine();
            }
        }

        private static void Move(string direction, ref int playerRow, ref int playerCol)
        {
            if (direction == "W")
            {
                playerRow--;
            }
            else if (direction == "A")
            {
                playerCol--;
            }
            else if (direction == "D")
            {
                playerCol++;
            }
            else if (direction == "S")
            {
                playerRow++;
            }
        }

        private static void ReturnPosition(string direction, ref int playerRow, ref int playerCol)
        {
            if (direction == "W")
            {
                playerRow++;
            }
            else if (direction == "A")
            {
                playerCol++;
            }
            else if (direction == "D")
            {
                playerCol--;
            }
            else if (direction == "S")
            {
                playerRow--;
            }
        }
    }
}
