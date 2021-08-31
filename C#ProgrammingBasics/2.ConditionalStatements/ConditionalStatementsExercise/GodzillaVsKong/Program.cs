using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double pStatist = double.Parse(Console.ReadLine());

            double pDecor = budget * 0.10;

            if (statists >150)
            {
                double pClothes = statists * pStatist * 0.90;

                if (pDecor + pClothes > budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {pDecor + (pClothes - budget):f2} leva more.");
                }
                else
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {budget - (pDecor + pClothes):f2} leva left.");

                }
            }
            else
            {
                double pClothes = statists * pStatist;
                if (pDecor + pClothes > budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {pDecor + (pClothes - budget):f2} leva more.");
                }
                else
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {budget - (pDecor + pClothes):f2} leva left.");
                }
            }
        }
    }
}
