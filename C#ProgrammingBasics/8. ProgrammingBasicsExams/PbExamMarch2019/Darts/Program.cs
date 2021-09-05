using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string zone = Console.ReadLine();

            int shots = 0;
            int sucShots = 0;
            int startP = 301;

            while (zone != "Retire")
            {
                int points = int.Parse(Console.ReadLine());
                if (zone == "Triple")
                {
                    points = points * 3;
                }
                else if (zone == "Double")
                {
                    points = points * 2;
                }

                if (startP >= points)
                {
                    sucShots++;
                    startP -= points;
                    if (startP == 0)
                    {
                        Console.WriteLine($"{name} won the leg with {sucShots} shots.");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    shots++;
                }
                zone = Console.ReadLine();
            }
            Console.WriteLine($"{name} retired after {shots} unsuccessful shots.");
        }
    }
}
