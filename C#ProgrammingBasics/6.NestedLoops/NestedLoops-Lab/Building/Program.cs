using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
                if (i == floors)
                {
                    for (int c = 0; c < rooms; c++)
                    {
                        Console.Write($"L{i}{c} ");
                    }
                    Console.WriteLine();
                }
                else if (i % 2 != 0)
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 0; k < rooms; k++)
                    {
                        Console.Write($"O{i}{k} ");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}