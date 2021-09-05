using System;

namespace BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournament = Console.ReadLine();

            double wins = 0;
            double loses = 0;
            double gamesC = 0;


            while (tournament != "End of tournaments")
            {
                int games = int.Parse(Console.ReadLine());

                for (int i = 1; i <= games; i++)
                {
                    gamesC++;
                    int aP = int.Parse(Console.ReadLine());
                    int bP = int.Parse(Console.ReadLine());

                    if (aP > bP)
                    {
                        wins++;
                        Console.WriteLine($"Game {i} of tournament {tournament}: win with {aP - bP} points.");
                    }
                    else
                    {
                        loses++;
                        Console.WriteLine($"Game {i} of tournament {tournament}: lost with {bP - aP} points.");
                    }
                }
                tournament = Console.ReadLine();
            }
            Console.WriteLine($"{wins / gamesC * 100:F2}% matches win");
            Console.WriteLine($"{loses / gamesC * 100:F2}% matches lost");
        }
    }
}
