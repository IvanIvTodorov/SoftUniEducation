using System;

namespace SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int season = int.Parse(Console.ReadLine());
            int episod = int.Parse(Console.ReadLine());
            double timeE = double.Parse(Console.ReadLine());


            double advert = timeE * 0.20;
            double allEpisod = season * episod;
            double alltime = allEpisod * timeE + (allEpisod * advert) + (season * 10);

            Console.WriteLine($"Total time needed to watch the {serial} series is {alltime} minutes.");

        }
    }
}
