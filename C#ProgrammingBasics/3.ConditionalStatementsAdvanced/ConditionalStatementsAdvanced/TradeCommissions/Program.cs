using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            decimal sales = decimal.Parse(Console.ReadLine());

            if (sales >=0 && sales <= 500)
            {
                switch (city)
                {
                    case "sofia":
                        Console.WriteLine($"{sales * 0.05m:f2}");
                        break;
                    case "varna":
                        Console.WriteLine($"{sales * 0.045m:f2}");
                        break;
                    case "plovdiv":
                        Console.WriteLine($"{sales * 0.055m:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 500 && sales <=1000)
            {
                switch (city)
                {
                    case "sofia":
                        Console.WriteLine($"{sales * 0.07m:f2}");
                        break;
                    case "varna":
                        Console.WriteLine($"{sales * 0.075m:f2}");
                        break;
                    case "plovdiv":
                        Console.WriteLine($"{sales * 0.08m:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (city)
                {
                    case "sofia":
                        Console.WriteLine($"{sales * 0.08m:f2}");
                        break;
                    case "varna":
                        Console.WriteLine($"{sales * 0.10m:f2}");
                        break;
                    case "plovdiv":
                        Console.WriteLine($"{sales * 0.12m:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 10000)
            {
                switch (city)
                {
                    case "sofia":
                        Console.WriteLine($"{sales * 0.12m:f2}");
                        break;
                    case "varna":
                        Console.WriteLine($"{sales * 0.13m:f2}");
                        break;
                    case "plovdiv":
                        Console.WriteLine($"{sales * 0.145m:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
