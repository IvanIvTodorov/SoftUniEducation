using System;

namespace AluminiumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivery = Console.ReadLine();

            double price = 0;

            if (qty <= 10 )
            {
                Console.WriteLine("Invalid order");
                Environment.Exit(0);
            }
            switch (type)
            {
                case "90X130":
                    if (qty <= 30)
                    {
                        price = (double)qty * 110;
                    }
                    else if (qty > 30 && qty <= 60 )
                    {
                        price = (double)qty * 110 * 0.95;
                    }
                    else
                    {
                        price = (double)qty * 110 * 0.92;
                    }
                    break;
                case "100X150":
                    if (qty <= 40)
                    {
                        price = (double)qty * 140;
                    }
                    else if (qty > 40 && qty <= 80)
                    {
                        price = (double)qty * 140 * 0.94;
                    }
                    else
                    {
                        price = (double)qty * 140 * 0.90;
                    }
                    break;
                case "130X180":
                    if (qty <= 20)
                    {
                        price = (double)qty * 190;
                    }
                    else if (qty > 20 && qty <= 50)
                    {
                        price = (double)qty * 190 * 0.92;
                    }
                    else
                    {
                        price = (double)qty * 190 * 0.88;
                    }
                    break;
                case "200X300":
                    if (qty <= 25)
                    {
                        price = (double)qty * 250;
                    }
                    else if (qty > 25 && qty <= 50)
                    {
                        price = (double)qty * 250 * 0.91;
                    }
                    else
                    {
                        price = (double)qty * 250 * 0.86;
                    }
                    break;
            }
            switch (delivery)
            {
                case "With delivery":
                    price = price + 60;
                    break;
            }
            if (qty > 99)
            {
                price = price * 0.96;
            }

            Console.WriteLine($"{price:F2} BGN");


        }
    }
}
