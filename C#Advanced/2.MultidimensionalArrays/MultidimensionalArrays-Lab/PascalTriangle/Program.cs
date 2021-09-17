using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[][] jagged = new long[size][];

            for (int c = 0; c < jagged.Length; c++)
            {
                jagged[c] = new long[c + 1];

                for (int r = 0; r < jagged[c].Length; r++)
                {
                    if (r == 0 || r == jagged[c].Length - 1)
                    {
                        jagged[c][r] = 1;                       
                    }
                    else
                    {
                        jagged[c][r] = jagged[c - 1][r - 1] + jagged[c - 1][r];
                    }
                    
                    Console.Write($"{jagged[c][r]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
