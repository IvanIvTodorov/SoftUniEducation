using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            decimal price = 0m;

            switch (destination)
            {

                case "France":
                    switch (date)
                    {
                        case "21-23":
                            price = nights * 30m;
                            break;
                        case "24-27":
                            price = nights * 35m;
                            break;
                        case "28-31":
                            price = nights * 40m;
                            break;

                    }
                    break;
                case "Italy":
                    switch (date)
                    {
                        case "21-23":
                            price = nights * 28m;
                            break;
                        case "24-27":
                            price = nights * 32m;
                            break;
                        case "28-31":
                            price = nights * 39m;
                            break;

                    }
                    break;
                case "Germany":
                    switch (date)
                    {
                        case "21-23":
                            price = nights * 32m;
                            break;
                        case "24-27":
                            price = nights * 37m;
                            break;
                        case "28-31":
                            price = nights * 43m;
                            break;

                    }
                    break;
            }

            Console.WriteLine($"Easter trip to {destination} : {price:F2} leva.");
        }
    }
}
