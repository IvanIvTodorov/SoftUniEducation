using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal p1Number = 0.00m;
            decimal p2Number = 0.00m;
            decimal p3Number = 0.00m;
            decimal p4Number = 0.00m;
            decimal p5Number = 0.00m;

            for (int i = 1; i <= n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1Number += 1m;
                }
                else if (number >= 200 && number < 400)
                {
                    p2Number += 1m;
                }
                else if (number >= 400 && number < 600)
                {
                    p3Number += 1m;
                }
                else if (number >= 600 && number < 800)
                {
                    p4Number += 1m;
                }
                else
                {
                    p5Number += 1m;
                }
            }
            decimal p1 = p1Number / n * 100m;
            decimal p2 = p2Number / n * 100m;
            decimal p3 = p3Number / n * 100m;
            decimal p4 = p4Number / n * 100m;
            decimal p5 = p5Number / n * 100m;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
