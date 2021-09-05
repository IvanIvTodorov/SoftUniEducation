using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int bread = int.Parse(Console.ReadLine());

            double flour = 0;
            double sugar = 0;
            double maxF = 0;
            double maxS = 0;

            for (int i = bread; i > 0; i--)
            {
                int usedS = int.Parse(Console.ReadLine());
                int usedF = int.Parse(Console.ReadLine());

                if (usedF > maxF)
                {
                    maxF = usedF;
                }
                if (usedS > maxS)
                {
                    maxS = usedS;
                }

                flour += usedF;
                sugar += usedS;
            }
            double qtyF = Math.Ceiling(flour / 750);
            double qtyS = Math.Ceiling(sugar / 950);

            Console.WriteLine($"Sugar: {qtyS}");
            Console.WriteLine($"Flour: {qtyF}");
            Console.WriteLine($"Max used flour is {maxF} grams, max used sugar is {maxS} grams.");
        }
    }
}
