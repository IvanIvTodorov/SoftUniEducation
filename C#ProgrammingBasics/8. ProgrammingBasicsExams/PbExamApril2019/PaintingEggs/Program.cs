using System;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColour = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());

            int price = 0;

            switch (eggsSize)
            {
                case "Large":
                    switch (eggsColour)
                    {
                        case "Red":
                            price = qty * 16;
                            break;
                        case "Green":
                            price = qty * 12;
                            break;
                        case "Yellow":
                            price = qty * 9;
                            break;
                    }
                    break;
                case "Medium":
                    switch (eggsColour)
                    {
                        case "Red":
                            price = qty * 13;
                            break;
                        case "Green":
                            price = qty * 9;
                            break;
                        case "Yellow":
                            price = qty * 7;
                            break;
                    }
                    break;
                case "Small":
                    switch (eggsColour)
                    {
                        case "Red":
                            price = qty * 9;
                            break;
                        case "Green":
                            price = qty * 8;
                            break;
                        case "Yellow":
                            price = qty * 5;
                            break;
                    }
                    break;
            }
            double finalP = price * 0.65;
            Console.WriteLine($"{finalP:F2} leva.");
        }
    }
}
