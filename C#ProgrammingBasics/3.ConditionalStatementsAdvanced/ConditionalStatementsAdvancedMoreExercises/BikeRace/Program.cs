using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int junior = int.Parse(Console.ReadLine());
            int senior = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            decimal jTrail = junior * 5.50m;
            decimal sTrail = senior * 7m;
            decimal jCountry = junior * 8m;
            decimal sCountry = senior * 9.50m;
            decimal jDown = junior * 12.25m;
            decimal sDown = senior * 13.75m;
            decimal jRoad = junior * 20m;
            decimal sRoad = senior * 21.50m;

            switch (type)
            {
                case "cross-country":
                    if (junior + senior >= 50)
                    {
                        Console.WriteLine($"{(jCountry + sCountry) * 0.75m * 0.95m:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"{(jCountry + sCountry) * 0.95m:F2}");
                    }
                    break;
                case "trail":
                    Console.WriteLine($"{(jTrail + sTrail) * 0.95m:f2}");
                    break;
                case "downhill":
                    Console.WriteLine($"{(jDown + sDown) * 0.95m:f2}");
                    break;
                case "road":
                    Console.WriteLine($"{(sRoad + jRoad) * 0.95m:f2}");
                    break;
            }
           
        }
    }
}
