using System;

namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysMissing = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double kgFirst = double.Parse(Console.ReadLine());
            double kgSecond = double.Parse(Console.ReadLine());
            double kgThird = double.Parse(Console.ReadLine());


            double first = (double)daysMissing * kgFirst;
            double second = (double)daysMissing * kgSecond;
            double third = (double)daysMissing * kgThird;

            double all = first + second + third;

            if (foodLeft < all)
            {
                Console.WriteLine($"{Math.Ceiling(all - foodLeft)} more kilos of food are needed.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(foodLeft - all)} kilos of food left.");
            }
        }
    }
}
