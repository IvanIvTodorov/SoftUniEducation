using System;

namespace TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennis = double.Parse(Console.ReadLine());
            int qtyTenis = int.Parse(Console.ReadLine());
            int qtyTrainres = int.Parse(Console.ReadLine());


            double trainers = tennis * 1 / 6;
            double priceTenis = tennis * qtyTenis;
            double priceTrainers = trainers * qtyTrainres;
            double priceOth = (priceTenis + priceTrainers) * 0.20;
            double priceAll = priceTenis + priceTrainers + priceOth;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceAll * 1 / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceAll * 7 / 8)}");
        }
    }
}
