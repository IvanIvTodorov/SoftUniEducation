using System;

namespace DivideWithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal p1Number = 0.00m;
            decimal p2Number = 0.00m;
            decimal p3Number = 0.00m;

            for (int i = 1; i <= n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p1Number += 1;
                }
                if (number % 3 == 0)
                {
                    p2Number += 1;
                }
                if (number % 4 == 0)
                {
                    p3Number += 1;
                }
            }

            decimal p1 = p1Number / n * 100m;
            decimal p2 = p2Number / n * 100m;
            decimal p3 = p3Number / n * 100m;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
