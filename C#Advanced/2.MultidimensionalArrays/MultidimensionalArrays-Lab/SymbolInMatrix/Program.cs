using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = symbols[c].ToString();
                }
            }

            string lookingFor = Console.ReadLine();

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (lookingFor == matrix[rows,col])
                    {
                        Console.WriteLine($"({rows}, {col})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{lookingFor} does not occur in the matrix");
        }
    }
}
