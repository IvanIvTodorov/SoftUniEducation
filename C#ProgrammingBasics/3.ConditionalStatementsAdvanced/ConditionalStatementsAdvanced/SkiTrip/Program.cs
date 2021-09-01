using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine().ToLower();
            string raiting = Console.ReadLine().ToLower();

            decimal nights = days - 1;

            if (days < 10)
            {
                if (raiting == "positive")
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{(nights * 18.00m) + ((nights * 18.00m) * 0.25m):F2}");
                            break;
                        case "apartment":
                            Console.WriteLine($"{((nights * 25.00m) * 0.70m) + (((nights * 25.00m) * 0.70m) * 0.25m):F2}");
                            break;
                        case "president apartment":
                            Console.WriteLine($"{((nights * 35.00m) * 0.90m) + (((nights * 35.00m) * 0.90m) * 0.25m):F2}");
                            break;
                    }
                }
                else if (raiting == "negative")
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{(nights * 18.00m) - ((nights * 18.00m) * 0.10m):f2}");
                            break;
                        case "apartment":
                            Console.WriteLine($"{((nights * 25.00m) * 0.70m) - (((nights * 25.00m) * 0.70m) * 0.10m):F2}");
                            break;
                        case "president apartment":
                            Console.WriteLine($"{((nights * 35.00m) * 0.90m) - (((nights * 35.00m) * 0.90m) * 0.10m):F2}");
                            break;
                    }
                }
            }
            else if (days >=10 && days <=15)
            {
                if (raiting == "positive")
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{(nights * 18.00m) + ((nights * 18.00m) * 0.25m):F2}");
                            break;
                        case "apartment":
                            Console.WriteLine($"{((nights * 25.00m) * 0.65m) + (((nights * 25.00m) * 0.65m) * 0.25m):F2}");
                            break;
                        case "president apartment":
                            Console.WriteLine($"{((nights * 35.00m) * 0.85m) + (((nights * 35.00m) * 0.85m) * 0.25m):F2}");
                            break;
                    }
                }
                else if (raiting == "negative")
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{(nights * 18.00m) - ((nights * 18.00m) * 0.10m):f2}");
                            break;
                        case "apartment":
                            Console.WriteLine($"{((nights * 25.00m) * 0.65m) - (((nights * 25.00m) * 0.65m) * 0.10m):F2}");
                            break;
                        case "president apartment":
                            Console.WriteLine($"{((nights * 35.00m) * 0.85m) - (((nights * 35.00m) * 0.85m) * 0.10m):F2}");
                            break;
                    }
                }
            }
            else if (days > 15)
            {
                if (raiting == "positive")
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{(nights * 18.00m) + ((nights * 18.00m) * 0.25m):F2}");
                            break;
                        case "apartment":
                            Console.WriteLine($"{((nights * 25.00m)* 0.50m) + (((nights * 25.00m) * 0.50m) * 0.25m):F2}");
                            break;
                        case "president apartment":
                            Console.WriteLine($"{((nights * 35.00m) * 0.80m) + (((nights * 35.00m) * 0.80m) * 0.25m):F2}");
                            break;
                    }
                }
                else if (raiting == "negative")
                {
                    switch (room)
                    {
                        case "room for one person":
                            Console.WriteLine($"{(nights * 18.00m) - ((nights * 18.00m) * 0.10m):F2}");
                            break;
                        case "apartment":
                            Console.WriteLine($"{((nights * 25.00m) * 0.50m) - (((nights * 25.00m) * 0.50m) * 0.10m):F2}");
                            break;
                        case "president apartment":
                            Console.WriteLine($"{((nights * 35.00m) * 0.80m) - (((nights * 35.00m) * 0.80m) * 0.10m):F2}");
                            break;
                    }
                }
            }
        }


    }
}

