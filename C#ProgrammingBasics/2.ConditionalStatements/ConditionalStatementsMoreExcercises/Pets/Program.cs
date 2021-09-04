using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogF = double.Parse(Console.ReadLine());
            double catF = double.Parse(Console.ReadLine());
            double turtleF = double.Parse(Console.ReadLine());

            double turtleKgF = turtleF / 1000;
            double foodUsed = days * dogF + days * catF + days * turtleKgF;


            if (food >= foodUsed)
            {
                Console.WriteLine($"{Math.Floor(food - foodUsed)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodUsed - food)} more kilos of food are needed.");
            }
        }
    }
}
