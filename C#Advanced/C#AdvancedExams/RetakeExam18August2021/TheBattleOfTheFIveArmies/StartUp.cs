using System;

namespace TheBattleOfTheFIveArmies
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int armor = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            string[][] field = new string[rows][];
            int[] armyPosition = null;
            for (int i = 0; i < rows; i++)
            {
                string rowInput = Console.ReadLine();
                field[i] = new string[rowInput.Length];
                for (int j = 0; j < rowInput.Length; j++)
                {
                    field[i][j] = rowInput[j].ToString();

                    if (field[i][j] == "A")
                    {
                        armyPosition = new int[] { i, j };
                        field[i][j] = "-";
                    }
                }
            }
            int ArmyRow = armyPosition[0];
            int ArmyCol = armyPosition[1];
            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string direction = command[0];
                int EnemyRow = int.Parse(command[1]);
                int EnemyCol = int.Parse(command[2]);               
                const int REDUCE_EMPTY = 1;
                const int REDUCE_ORC = 2;

                try
                {
                    MovePosition(direction, ref ArmyRow, ref ArmyCol);

                    AddOrc(field, EnemyRow, EnemyCol);

                    armor -= REDUCE_EMPTY;
                    if (field[ArmyRow][ArmyCol] == "O")
                    {
                        armor -= REDUCE_ORC;

                        if (armor > 0)
                        {
                            EmptySpace(field, ArmyRow, ArmyCol);
                        }
                    }
                    else if (field[ArmyRow][ArmyCol] == "M")
                    {
                        EmptySpace(field, ArmyRow, ArmyCol);
                        Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                        PrintField(field);
                        StopTheProgram();
                    }

                    if (armor <= 0)
                    {
                        field[ArmyRow][ArmyCol] = "X";
                        Console.WriteLine($"The army was defeated at {ArmyRow};{ArmyCol}.");
                        PrintField(field);
                        StopTheProgram();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    ReturnPosition(direction, ref ArmyRow, ref ArmyCol);
                }
            }

        }

        private static void ReturnPosition(string direction, ref int ArmyRow, ref int ArmyCol)
        {
            if (direction == "up")
            {
                ArmyRow += 1;
            }
            else if (direction == "left")
            {
                ArmyCol += 1;
            }
            else if (direction == "right")
            {
                ArmyCol -= 1;
            }
            else if (direction == "down")
            {
                ArmyRow -= 1;
            }
        }

        private static void MovePosition(string direction, ref int ArmyRow, ref int ArmyCol)
        {
            if (direction == "up")
            {
                ArmyRow -= 1;
            }
            else if (direction == "left")
            {
                ArmyCol -= 1;
            }
            else if (direction == "right")
            {
                ArmyCol += 1;
            }
            else if (direction == "down")
            {
                ArmyRow += 1;
            }
        }

        private static void AddOrc(string[][] field, int EnemyRow, int EnemyCol)
        {
            field[EnemyRow][EnemyCol] = "O";
        }

        private static void StopTheProgram()
        {
            Environment.Exit(0);
        }

        private static void PrintField(string[][] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }
        }

        private static void EmptySpace(string[][] field, int ArmyRow, int ArmyCol)
        {
            field[ArmyRow][ArmyCol] = "-";
        }
    }
}
