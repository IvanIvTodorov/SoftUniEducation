using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());   

            int[][] jagged = new int[size][];

            for (int r = 0; r < jagged.Length; r++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jagged[r] = new int[inputNumbers.Length];
                for (int c = 0; c < inputNumbers.Length; c++)
                {
                    jagged[r][c] = inputNumbers[c];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] toDo = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int first = int.Parse(toDo[1]);
                int second = int.Parse(toDo[2]);

                if (toDo[0] == "Add")
                {
                    if (first >= 0 && second >= 0 && first < jagged.Length)
                    {
                        jagged[first][second] += int.Parse(toDo[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    
                }
                else
                {
                    if (first >= 0 && second >= 0 && first < jagged.Length)
                    {
                        jagged[first][second] -= int.Parse(toDo[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
