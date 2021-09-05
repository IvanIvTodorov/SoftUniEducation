using System;

namespace PcGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;

            for (int i = 1; i <= n; i++)
            {
                string game = Console.ReadLine();
                switch (game)
                {
                    case "Hearthstone":
                        a++;
                        break;
                    case "Fornite":
                        b++;
                        break;
                    case "Overwatch":
                        c++;
                        break;
                    default:
                        d++;
                        break;
                }

            }
            Console.WriteLine($"Hearthstone - {a / (double)n * 100:F2}%");
            Console.WriteLine($"Fornite - {b / (double)n * 100:f2}%");
            Console.WriteLine($"Overwatch - {c / (double)n * 100:F2}%");
            Console.WriteLine($"Others - {d / (double)n * 100:F2}%");
        }
    }
}
