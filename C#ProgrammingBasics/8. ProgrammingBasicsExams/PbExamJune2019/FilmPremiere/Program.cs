using System;

namespace FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string menu = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double price = 0;


            switch (movie)
            {
                case "John Wick":
                    switch (menu)
                    {
                        case "Drink":
                            price = (double)tickets * 12;
                            break;
                        case "Popcorn":
                            price = (double)tickets * 15;
                            break;
                        case "Menu":
                            price = (double)tickets * 19;
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (menu)
                    {
                           
                        case "Drink":
                            price = (double)tickets * 18;
                            break;
                        case "Popcorn":
                            price = (double)tickets * 25;
                            break;
                        case "Menu":
                            price = (double)tickets * 30;
                            break;
                    }
                    break;
                case "Jumanji":
                    switch (menu)
                    {
                        case "Drink":
                            price = (double)tickets * 9;
                            break;
                        case "Popcorn":
                            price = (double)tickets * 11;
                            break;
                        case "Menu":
                            price = (double)tickets * 14;
                            break;
                    }
                    break;
            }
            if (movie == "Star Wars" && tickets >= 4)
            {
                price = price * 0.70;
            }
            else if (movie == "Jumanji" && tickets == 2)
            {
                price = price * 0.85;
            }

            Console.WriteLine($"Your bill is {price:f2} leva.");
        }
    }
}
