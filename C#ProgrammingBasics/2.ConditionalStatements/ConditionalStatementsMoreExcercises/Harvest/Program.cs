using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double litersW = ((x * y) * 0.40) / 2.5;

            if (litersW < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - litersW)} liters wine needed.");
            }
            else if (litersW >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersW)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersW - z)} liters left -> {Math.Ceiling(((litersW - z) / workers))} liters per person.");
            }
        }
	}
    
}
