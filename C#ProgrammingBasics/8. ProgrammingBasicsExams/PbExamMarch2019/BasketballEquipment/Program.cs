using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearP = int.Parse(Console.ReadLine());

            double shoesP = yearP * 0.60;
            double clothes = yearP * 0.60 * 0.80;
            double ball = (yearP * 0.60 * 0.80) * 1 / 4;
            double accessoaries = ((yearP * 0.60 * 0.80) * 1 / 4) * 1 / 5;

            Console.WriteLine($"{yearP + shoesP + clothes + ball + accessoaries:f2}");
        }
    }
}
