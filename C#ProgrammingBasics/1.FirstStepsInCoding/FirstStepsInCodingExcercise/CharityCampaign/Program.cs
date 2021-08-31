using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int nDays = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffle = int.Parse(Console.ReadLine());
            double pancake = int.Parse(Console.ReadLine());
            int cakeP = 45;
            double waffleP = 5.8;
            double pancakeP = 3.2;

            double pCakeDay = cakes * cakeP;
            double pwaffleDay = waffle * waffleP;
            double pPancakeDay = pancake * pancakeP;

            double pricePerday = (pCakeDay + pwaffleDay + pPancakeDay) * chefs;

            Console.WriteLine($"{(nDays * pricePerday) - (nDays * pricePerday) * 0.125}");
        }
    }
}
