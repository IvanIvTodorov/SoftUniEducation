using System;

namespace OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string type = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double price = 0;

            switch (movie)
            {
                case "A Star Is Born":
                    switch (type)
                    {
                        case "normal":
                            price = tickets * 7.50;
                            break;
                        case "luxury":
                            price = tickets * 10.50;
                            break;
                        case "ultra luxury":
                            price = tickets * 13.50;
                            break;
                    }
                    break;
                case "Bohemian Rhapsody":
                    switch (type)
                    {
                        case "normal":
                            price = tickets * 7.35;
                            break;
                        case "luxury":
                            price = tickets * 9.45;
                            break;
                        case "ultra luxury":
                            price = tickets * 12.75;
                            break;
                    }
                    break;
                case "Green Book":
                    switch (type)
                    {
                        case "normal":
                            price = tickets * 8.15;
                            break;
                        case "luxury":
                            price = tickets * 10.25;
                            break;
                        case "ultra luxury":
                            price = tickets * 13.25;
                            break;
                    }
                    break;
                case "The Favourite":
                    switch (type)
                    {
                        case "normal":
                            price = tickets * 8.75;
                            break;
                        case "luxury":
                            price = tickets * 11.55;
                            break;
                        case "ultra luxury":
                            price = tickets * 13.95;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"{movie} -> {price:f2} lv.");
        }
    }
}
