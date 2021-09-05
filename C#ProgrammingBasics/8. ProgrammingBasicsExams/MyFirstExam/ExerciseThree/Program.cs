using System;

namespace ExerciseThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int km = int.Parse(Console.ReadLine());

            double price = 0;

            switch (type)
            {
                case "standard":
                    if (kg < 1)
                    {
                        price = 0.03 * km;
                    }
                    else if (kg >=1 && kg < 10)
                    {
                        price = 0.05 * km;
                    }
                    else if (kg >= 10 && kg < 40)
                    {
                        price = 0.10 * km;
                    }
                    else if (kg >= 40 && kg < 90)
                    {
                        price = 0.15 * km;
                    }
                    else
                    {
                        price = 0.20 * km;
                    }
                    break;
                case "express":
                    if (kg < 1)
                    {
                        price = km * 0.03;
                        price = price + (km * (kg * (0.03 * 0.8)));
                    }
                    else if (kg >= 1 && kg < 10)
                    {
                        price = km * 0.05;
                        price = price + (km * (kg * 0.05 * 0.4));
                    }
                    else if (kg >= 10 && kg < 40)
                    {
                        price = km * 0.10;
                        price = price + (km * (kg * 0.10 * 0.05));
                    }
                    else if (kg >= 40 && kg < 90)
                    {
                        price = km * 0.15;
                        price = price + (km * (kg * 0.15 * 0.02));
                    }
                    else
                    {
                        price = km * 0.20;
                        price = price + (km * (kg * 0.20 * 0.01));
                    }
                    break;
            }

            Console.WriteLine($"The delivery of your shipment with weight of {kg:f3} kg. would cost {price:F2} lv.");
        }
    }
}
