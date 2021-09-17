using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = ReadFromConsole();

            int[,] matrix = new int[size[0], size[1]];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] columnNum = ReadFromConsole();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r,c] = columnNum[c];
                }
            }

            int curNum = 0;
            int maxNum = 0;
            int[] index = new int[2];

            for (int rows = 0; rows < matrix.GetLength(0) - 1 ; rows++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1 ; col++)
                {
                    curNum += matrix[rows, col];
                    curNum += matrix[rows, col + 1];
                    curNum += matrix[rows + 1, col];
                    curNum += matrix[rows + 1, col + 1];

                    if (curNum > maxNum)
                    {
                        maxNum = curNum;
                        index[0] = rows;
                        index[1] = col;                       
                    }
                    curNum = 0;
                }               
            }
            Console.WriteLine($"{matrix[index[0], index[1]]} {matrix[index[0], index[1] + 1 ]}");
            Console.WriteLine($"{matrix[index[0] + 1, index[1]]} {matrix[index[0] + 1 , index[1] + 1]}");
            Console.WriteLine(maxNum);
        }

        private static int[] ReadFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
