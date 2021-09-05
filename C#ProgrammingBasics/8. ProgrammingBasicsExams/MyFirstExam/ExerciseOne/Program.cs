using System;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int cards = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            double priceNights = (double)people * nights * 20;
            double priceCards = (double)people * cards * 1.60;
            double priceTickets = (double)people * tickets * 6;

            double finalPrice = (priceNights + priceCards + priceTickets) * 1.25;

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
