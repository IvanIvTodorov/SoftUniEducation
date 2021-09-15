using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 flour , 10 eggs, 1 appron
            double budget = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double price = 0;
            int count = 0;
            int flour = 0;
            int egg = 0;
            double apron = 0;
            for (int i = 1; i <= student; i++)
            {
                count++;
                if (count == 5)
                {
                    egg += 10;
                    apron++;
                    count = 0;
                }
                else
                {
                    egg += 10;
                    apron++;
                    flour++;
                }
            }

            eggPrice = egg * eggPrice;
            apronPrice = apronPrice * (Math.Ceiling(student * 1.2));
            flourPrice = flour * flourPrice;


            price = eggPrice + apronPrice + flourPrice;

            if (budget  >= price)
            {
                Console.WriteLine($"Items purchased for {price:f2}$.");
            }
            else
            {
                Console.WriteLine($"{price - budget:F2}$ more needed.");
            }
        }
    }
}
