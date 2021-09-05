using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("| ");
                }
                for (int k = 1; k < n; k++)
                {
                    if (i == 1 && k == n - 1 || i == n && k == n - 1)
                    {
                        Console.Write("+ ");
                    }
                    else if (k == n - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
