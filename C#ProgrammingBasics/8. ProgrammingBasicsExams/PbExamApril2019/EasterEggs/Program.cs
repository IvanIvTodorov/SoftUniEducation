using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            int max = 0;
            string finalColour = "";

            for (int i = qty; i >= 0; i--)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        red++;
                        break;
                    case "orange":
                        orange++;
                        break;
                    case "blue":
                        blue++;
                        break;
                    case "green":
                        green++;
                        break;
                }
            }
            if (red > orange && red > blue && red > green)
            {
                max += red;
                finalColour = "red";
            }
            else if (green > orange && green > blue && green > red)
            {
                max += green;
                finalColour = "green";
            }
            else if (blue > orange && blue > red && blue > green)
            {
                max += blue;
                finalColour = "blue";

            }
            else if (orange > blue && orange > red && orange > green)
            {
                max += orange;
                finalColour = "orange";
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {max} -> {finalColour}");
        }
    }
}
