using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrys = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            decimal pChot = chrys * 2.00m;
            decimal pRhot = roses * 4.10m;
            decimal pThot = tulips * 2.50m;
            decimal pChotHol = chrys * 2.00m + ((chrys * 2.00m) * 0.15m);
            decimal pRhothol = roses * 4.10m + ((roses * 4.10m) * 0.15m);
            decimal pThothol = tulips * 2.50m + ((tulips * 2.50m) * 0.15m);
            decimal pCcold = chrys * 3.75m;
            decimal pRcold = roses * 4.50m;
            decimal pTcold = tulips * 4.15m;
            decimal pCcoldhol = chrys * 3.75m + ((chrys * 3.75m) * 0.15m);
            decimal pRcoldhol = roses * 4.50m + ((roses * 4.50m) * 0.15m);
            decimal pTcoldhol = tulips * 4.15m + ((tulips * 4.15m) * 0.15m);

            if (tulips > 7 && season == "Spring")
            {
                if (holiday == "Y" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pChotHol + pRhothol + pThothol) * 0.95m * 0.80m + 2m:f2}");
                }
                else if (holiday == "Y" && chrys + roses + tulips <= 20)
                {
                    Console.WriteLine($"{(pChotHol + pRhothol + pThothol) * 0.95m + 2m:F2}");
                }
                else if (holiday == "N" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pChot + pRhot + pThot) * 0.95m * 0.80m + 2m:f2}");
                }
                else
                {
                   Console.WriteLine($"{(pChot + pRhot + pThot + 2):f2}");
                }
            }
            else if (tulips <= 7 && season == "Spring")
            {
                if (holiday == "Y" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pChotHol + pRhothol + pThothol) * 0.80m + 2m:F2}");
                }
                else if (holiday == "Y" && chrys + roses + tulips <= 20)
                {
                    Console.WriteLine($"{pChotHol + pRhothol + pThothol + 2:f2}");
                }
                else if (holiday == "N" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pChot + pRhot + pThot) * 0.80m + 2m:f2}");
                }
                else
                {
                    Console.WriteLine($"{(pChot + pRhot + pThot + 2):f2}");
                }
            }
            else if (season == "Summer")
            {
                if (holiday == "Y" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pChotHol + pRhothol + pThothol) * 0.80m + 2m:f2}");
                }
                else if (holiday == "Y" && chrys + roses + tulips <= 20)
                {
                    Console.WriteLine($"{pChotHol + pRhothol + pThothol + 2:f2}");
                }
                else if (holiday == "N" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pChot + pRhot + pThot) * 0.80m + 2m:f2}");
                }
                else
                {
                    Console.WriteLine($"{(pChot + pRhot + pThot + 2):f2}");
                }
            }
            else if (roses >= 10 && season == "Winter")
            {
                if (holiday == "Y" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pCcoldhol + pRcoldhol + pTcoldhol) * 0.90m * 0.80m + 2m:F2}");
                }
                else if (holiday == "Y" && chrys + roses + tulips <= 20)
                {
                    Console.WriteLine($"{(pCcoldhol + pRcoldhol + pTcoldhol) * 0.90m + 2m:F2}");
                }
                else if (holiday == "N" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pCcold + pRcold + pTcold) * 0.90m * 0.80m + 2m:f2}");
                }
                else
                {
                    Console.WriteLine($"{(pCcold + pRcold + pTcold + 2):f2}");
                }
            }
            else if (roses < 10 && season == "Winter")
            {
                if (holiday == "Y" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pCcoldhol + pRcoldhol + pTcoldhol) * 0.80m + 2m:F2}");
                }
                else if (holiday == "Y" && chrys + roses + tulips <= 20)
                {
                    Console.WriteLine($"{(pCcoldhol + pRcoldhol + pTcoldhol + 2):F2}");
                }
                else if (holiday == "N" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pCcold + pRcold + pTcold) * 0.80m + 2m:f2}");
                }
                else
                {
                    Console.WriteLine($"{(pCcold + pRcold + pTcold + 2):f2}");
                }
            }
            else if (season == "Autumn")
            {
                if (holiday == "Y" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pCcoldhol + pRcoldhol + pTcoldhol) * 0.80m + 2m:F2}");
                }
                else if (holiday == "Y" && chrys + roses + tulips <= 20)
                {
                    Console.WriteLine($"{(pCcoldhol + pRcoldhol + pTcoldhol + 2):F2}");
                }
                else if (holiday == "N" && chrys + roses + tulips > 20)
                {
                    Console.WriteLine($"{(pCcold + pRcold + pTcold) * 0.80m + 2m:f2}");
                }
                else
                {
                    Console.WriteLine($"{(pCcold + pRcold + pTcold + 2):f2}");
                }
            }
        }
    }
}
