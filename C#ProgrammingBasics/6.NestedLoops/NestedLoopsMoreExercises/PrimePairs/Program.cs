using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int firstDif = int.Parse(Console.ReadLine()) + first;
            int secondDif = int.Parse(Console.ReadLine()) + second;

            for (int i = first; i <= firstDif; i++)
            {
                for (int c = second; c <= secondDif; c++)
                {
                    if (i % 2 != 0 && i % 3 != 0 && i % 4 != 0 && i % 5 != 0 && i % 6 != 0 && i % 7 != 0 && c % 2 != 0 && c % 3 != 0 && c % 4 != 0 && c % 5 != 0 && c % 6 != 0 && c % 7 != 0)
                    {
                        Console.WriteLine($"{i}{c}");
                    }
                }
            }

        }
    }
}
