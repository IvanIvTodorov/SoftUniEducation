using System;

namespace EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggsQty = int.Parse(Console.ReadLine());
            int yeastQty = int.Parse(Console.ReadLine());

            double flourP = flourPrice * flourKg;
            double sugarP = flourPrice * 0.75;
            double eggsP = flourPrice * 1.1;
            double yeastP = flourPrice * 0.75 * 0.20;
            double sugar = sugarKg * sugarP;
            double eggs = eggsQty * eggsP;
            double yeast = yeastQty * yeastP;



            double priceAll = flourP + sugar + eggs + yeast; ;

            Console.WriteLine($"{priceAll:F2}");
        }
    }
}
