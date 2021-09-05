using System;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double price = 0;
            double curPrice = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            price += 2.50;
                        }
                        else
                        {
                            price += 1;
                        }
                    }
                    else if (i % 2 != 0)
                    {
                        if (j % 2 == 0)
                        {
                            price += 1.25;
                        }
                        else
                        {
                            price += 1;
                        }
                    }
                }
                curPrice += price;
                Console.WriteLine($"Day: {i} - {price:F2} leva");
                price = 0;
            }
            Console.WriteLine($"Total: {curPrice:F2} leva");
        }
    }
}
