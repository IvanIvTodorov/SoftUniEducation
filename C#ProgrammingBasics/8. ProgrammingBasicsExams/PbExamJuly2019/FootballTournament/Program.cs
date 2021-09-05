using System;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            if (games == 0)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
                Environment.Exit(0);
            }

            int wins = 0;
            int loses = 0;
            int draws = 0;
            int points = 0;

            for (int i = 1; i <= games; i++)
            {
                string result = Console.ReadLine();

                switch (result)
                {
                    case "W":
                        wins++;
                        points += 3;
                        break;
                    case "L":
                        loses++;
                        points += 0;
                        break;
                    case "D":
                        draws++;
                        points += 1;
                        break;
                }
            }
            Console.WriteLine($"{team} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wins}");
            Console.WriteLine($"## D: {draws}");
            Console.WriteLine($"## L: {loses}");
            Console.WriteLine($"Win rate: {(double)wins / (double)games * 100:F2}%");
        }
    }
}
