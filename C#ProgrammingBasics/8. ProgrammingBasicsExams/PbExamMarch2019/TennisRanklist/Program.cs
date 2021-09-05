using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int turnaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            double wins = 0;
            int average = 0;

            for (int i = 1; i <= turnaments; i++)
            {
                string text = Console.ReadLine();

                switch (text)
                {
                    case "W":
                        points += 2000;
                        average += 2000;                        
                        wins++;
                        break;
                    case "F":
                        points += 1200;
                        average += 1200;
                        break;
                    case "SF":
                        points += 720;
                        average += 720;
                        break;
                }
            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {average / turnaments}");
            Console.WriteLine($"{(wins / (double)turnaments) * 100:f2}%");
        }
    }
}
