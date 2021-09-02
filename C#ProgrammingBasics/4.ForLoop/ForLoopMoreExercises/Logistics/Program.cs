using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());

            decimal micro = 0.00m;
            decimal truck = 0.00m;
            decimal train = 0.00m;
            decimal weightAll = 0.00m;


            for (int i = 1; i <= qty; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    micro += weight;
                }
                else if (weight > 3 && weight <= 11)
                {
                    truck += weight;
                }
                else
                {
                    train += weight;
                }
                weightAll += weight;
            }
            decimal microP = 200m * micro;
            decimal truckP = 175m * truck;
            decimal trainP = 120m * train;

            Console.WriteLine($"{(microP + truckP + trainP) / weightAll:f2}");
            Console.WriteLine($"{micro / weightAll * 100:f2}%");
            Console.WriteLine($"{truck / weightAll * 100:f2}%");
            Console.WriteLine($"{train / weightAll * 100:f2}%");
            }
    }
}
