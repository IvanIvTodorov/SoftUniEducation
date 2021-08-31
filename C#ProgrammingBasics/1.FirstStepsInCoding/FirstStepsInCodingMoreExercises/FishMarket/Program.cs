using System;

namespace FishMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double pSkum = double.Parse(Console.ReadLine());
            double pCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int midi = int.Parse(Console.ReadLine());

            double pPal = pSkum + (pSkum * 0.6);
            double pSafrid = pCaca + (pCaca * 0.8);

            double priceAll = pPal * kgPalamud + pSafrid * kgSafrid + midi * 7.50;

            Console.WriteLine($"{(float)priceAll:f2}");



        }
    }
}
