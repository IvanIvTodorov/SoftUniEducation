using System;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double pTrip = double.Parse(Console.ReadLine());
            int cPuzzle = int.Parse(Console.ReadLine());
            int cDolls = int.Parse(Console.ReadLine());
            int cBears = int.Parse(Console.ReadLine());
            int cMin = int.Parse(Console.ReadLine());
            int cTrucks = int.Parse(Console.ReadLine());

            double pPuzzle = cPuzzle * 2.60;
            double pDolls = cDolls * 3;
            double pBear = cBears * 4.10;
            double pMin = cMin * 8.20;
            double pTrucks = cTrucks * 2;

            double pALL = pPuzzle + pDolls + pBear + pMin + pTrucks;

            if (cPuzzle + cDolls + cBears + cMin + cTrucks >= 50)
            {
                double pDisc = pALL * 0.75 * 0.90;

                if (pDisc >= pTrip)
                {
                    double left = pDisc - pTrip;
                    Console.WriteLine($"Yes! {left:f2} lv left.");
                }
                else if (pDisc <= pTrip)
                {
                    double missing = pTrip - pDisc;
                    Console.WriteLine($"Not enough money! {missing:f2} lv needed.");
                }
            }
             else if (cPuzzle + cDolls + cBears + cMin + cTrucks < 50)
            {
                double pDisc = pALL * 0.90;

                if (pDisc >= pTrip)
                {
                    double left = pDisc - pTrip;
                    Console.WriteLine($"Yes! {left:f2} lv left.");
                }
                else if (pDisc <= pTrip)
                {
                    double missing = pTrip - pDisc;
                    Console.WriteLine($"Not enough money! {missing:F2} lv needed.");
                }
            }
        }
    }
}
