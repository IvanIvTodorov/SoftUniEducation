using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (km < 20)
            {
                if (day == "day")
                {
                    double dayP = km * 0.79 + 0.70;
                    Console.WriteLine($"{dayP:f2}");
                }
                else
                {
                    Console.WriteLine($"{(km * 0.90) + 0.70:f2}");
                }
            }
            else if (km >= 20 & km < 100)
            {
                Console.WriteLine($"{km * 0.09:f2}");    
            }
            else
            {
                Console.WriteLine($"{km * 0.06:f2}");
            }
        }
    }
}
