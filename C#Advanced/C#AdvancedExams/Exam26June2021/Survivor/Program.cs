using System;
using System.Text;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            string[][] field = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] addRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                field[row] = new string[addRow.Length];

                for (int col = 0; col < field[row].Length; col++)
                {
                    field[row][col] = addRow[col].ToString();
                }
            }

            int myTokens = 0;
            int oponentTokens = 0;
            string text = string.Empty;

            while ((text = Console.ReadLine()) != "Gong")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string whatToDo = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                try
                {
                    if (whatToDo == "Find")
                    {
                        if (field[row][col] == "T")
                        {
                            field[row][col] = "-";
                            myTokens++;
                        }
                    }
                    else
                    {
                        string position = command[3];
                        int move = 3;

                        if (field[row][col] == "T")
                        {
                            field[row][col] = "-";
                            oponentTokens++;
                        }

                        if (position == "up")
                        {
                            while (move != 0)
                            {
                                if (field[--row][col] == "T")
                                {
                                    field[row][col] = "-";
                                    oponentTokens++;
                                }
                                move--;
                            }
                        }
                        else if (position == "left")
                        {
                            while (move != 0)
                            {
                                if (field[row][--col] == "T")
                                {
                                    field[row][col] = "-";
                                    oponentTokens++;
                                }
                                move--;
                            }
                        }
                        else if (position == "right")
                        {
                            while (move != 0)
                            {
                                if (field[row][++col] == "T")
                                {
                                    field[row][col] = "-";
                                    oponentTokens++;
                                }
                                move--;
                            }
                        }
                        else if (position == "down")
                        {
                            while (move != 0)
                            {
                                if (field[++row][col] == "T")
                                {
                                    field[row][col] = "-";
                                    oponentTokens++;
                                }
                                move--;
                            }
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    sb.Append($"{field[row][col]} ");
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString().TrimEnd());
            Console.WriteLine($"Collected tokens: {myTokens}");
            Console.WriteLine($"Opponent's tokens: {oponentTokens}");
        }
    }
}
