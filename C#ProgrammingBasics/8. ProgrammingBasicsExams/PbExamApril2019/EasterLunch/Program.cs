using System;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int bread = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());

            decimal breadP = bread * 3.20m;
            decimal eggsP = eggs * 4.35m;
            decimal cookiesp = cookies * 5.40m;
            decimal paint = eggs * 12m * 0.15m;

            decimal pAll = breadP + eggsP + cookiesp + paint;

            Console.WriteLine($"{pAll:f2}");
        }
    }
}
