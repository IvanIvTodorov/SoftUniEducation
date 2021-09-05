using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double startPoints = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            double count = 0;

            for (int i = 1; i <= judges; i++)
            {
                string name = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                for (int j = 0; j < name.Length; j++)
                {
                    count++;
                }
                startPoints += count * points / 2;
                if (startPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {startPoints:f1}!");
                    Environment.Exit(0);
                }
                count = 0;
            }
            Console.WriteLine($"Sorry, {actor} you need {1250.5 - startPoints:f1} more!");
        }
    }
}
