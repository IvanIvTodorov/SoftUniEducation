using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();

            decimal first = 0;
            decimal second = 0;

            switch (country)
            {
                case "Russia":
                    switch (instrument)
                    {
                        case "ribbon":
                            first = 9.100m;
                            second = 9.400m;
                            break;
                        case "hoop":
                            first = 9.300m;
                            second = 9.800m;
                            break;
                        case "rope":
                            first = 9.600m;
                            second = 9.000m;
                            break;
                    }
                    break;
                case "Bulgaria":
                    switch (instrument)
                    {
                        case "ribbon":
                            first = 9.600m;
                            second = 9.400m;
                            break;
                        case "hoop":
                            first = 9.550m;
                            second = 9.750m;
                            break;
                        case "rope":
                            first = 9.500m;
                            second = 9.400m;
                            break;
                    }
                    break;
                case "Italy":
                    switch (instrument)
                    {
                        case "ribbon":
                            first = 9.200m;
                            second = 9.500m;
                            break;
                        case "hoop":
                            first = 9.450m;
                            second = 9.350m;
                            break;
                        case "rope":
                            first = 9.700m;
                            second = 9.150m;
                            break;
                    }
                    break;
            }

            Console.WriteLine($"The team of {country} get {first + second:F3} on {instrument}.");
            Console.WriteLine($"{((20 - (first + second)) / 20m) * 100:F2}%");
        }
    }
}
