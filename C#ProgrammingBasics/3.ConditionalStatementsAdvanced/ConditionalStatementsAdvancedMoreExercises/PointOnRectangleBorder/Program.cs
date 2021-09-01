using System;

namespace PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());


            if (x == x1 && y >= y1 && y <= y2 || x == x2 && y >= y1 && y <= y2)
            {    
                    Console.WriteLine("Border");
            }
            else if (y == y1 && x >= x1 && x <= x2 || y == y2 && x >= x1 && x <= x2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
