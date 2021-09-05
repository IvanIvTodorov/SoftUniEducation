using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int points = 0;
            int other = 0;

            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        red++;
                        points += 5;
                        break;
                    case "orange":
                        orange++;
                        points += 10;
                        break;
                    case "yellow":
                        yellow++;
                        points += 15;
                        break;
                    case "white":
                        white++;
                        points += 20;
                        break;
                    case "black":
                        black++;
                        points /= 2;
                        break;
                    default:
                        other++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {red}");
            Console.WriteLine($"Points from orange balls: {orange}");
            Console.WriteLine($"Points from yellow balls: {yellow}");
            Console.WriteLine($"Points from white balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
