using System;

namespace AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string aeroCompany = Console.ReadLine();
            int qtyAdults = int.Parse(Console.ReadLine());
            int qtyKids = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());


            double children = priceTicket * 0.30;
            double priceKids = (children + tax) * qtyKids;
            double priceAdult = (priceTicket + tax) * qtyAdults;
            double finalPrice = (priceKids + priceAdult ) * 0.20;

            Console.WriteLine($"The profit of your agency from {aeroCompany} tickets is {finalPrice:F2} lv.");
        }
    }
}
