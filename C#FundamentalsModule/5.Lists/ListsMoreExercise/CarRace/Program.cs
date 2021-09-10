using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> race = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            double first = 0;
            double second = 0;

            for (int i = 0; i < race.Count / 2; i++)
            {
                if (race[i] == 0)
                {
                    first *= 0.80;
                }
                else
                {
                    first += race[i];
                }
            }
            for (int i = race.Count - 1; i > race.Count / 2; i--)
            {
                if (race[i] == 0)
                {
                    second *= 0.80;
                }
                else
                {
                    second += race[i];
                }
            }
            if (first < second)
            {
                Console.WriteLine($"The winner is left with total time: {first}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {second}");
            }

            
        }
    }
}
