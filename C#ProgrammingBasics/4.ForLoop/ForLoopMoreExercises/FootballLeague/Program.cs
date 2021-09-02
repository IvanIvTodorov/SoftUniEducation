using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            decimal aFans = 0.00m;
            decimal bFans = 0.00m;
            decimal vFans = 0.00m;
            decimal gFans = 0.00m;
            decimal allFans = 0.00m;

            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        aFans += 1;
                        allFans += 1;
                        break;
                    case "B":
                        bFans += 1;
                        allFans += 1;
                        break;
                    case "V":
                        vFans += 1;
                        allFans += 1;
                        break;
                    case "G":
                        gFans += 1;
                        allFans += 1;
                        break;
                }
            }
            Console.WriteLine($"{aFans / allFans * 100:F2}%");
            Console.WriteLine($"{bFans / allFans * 100:F2}%");
            Console.WriteLine($"{vFans / allFans * 100:F2}%");
            Console.WriteLine($"{gFans / allFans * 100:F2}%");
            Console.WriteLine($"{allFans / capacity * 100:F2}%");
        }
    }
}
