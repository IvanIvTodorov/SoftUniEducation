using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double giftP = double.Parse(Console.ReadLine());

            double pAll = (magnolias * 3.25 + hyacinths * 4 + roses * 3.50 + cactus * 8) * 0.95;

            if (pAll >= giftP)
            {
                Console.WriteLine($"She is left with {Math.Floor(pAll - giftP)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftP - pAll)} leva.");
            }
        }
    }
}
