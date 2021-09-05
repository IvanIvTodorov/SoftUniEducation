using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            decimal price = 0m;

            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = (decimal)qty * 8.45m;
                            break;
                        case "Saturday":
                            price = (decimal)qty * 9.80m;
                            break;
                        case "Sunday":
                            price = (decimal)qty * 10.46m;
                            break;
                    }
                    if (qty >= 30)
                    {
                        price = price * 0.85m;
                    }
                    break;
                case "Business":
                    if (qty >= 100)
                    {
                        switch (day)
                        {
                            case "Friday":
                                price = ((decimal)qty - 10) * 10.90m;
                                break;
                            case "Saturday":
                                price = ((decimal)qty - 10) * 15.60m;
                                break;
                            case "Sunday":
                                price = ((decimal)qty - 10) * 16m;
                                break;
                        }
                    }
                    else
                    {
                        switch (day)
                        {
                            case "Friday":
                                price = (decimal)qty * 10.90m;
                                break;
                            case "Saturday":
                                price = (decimal)qty * 15.60m;
                                break;
                            case "Sunday":
                                price = (decimal)qty * 16m;
                                break;
                        }
                    }
                        break;
                case "Regular":
                    if (qty >= 10 && qty <= 20)
                    {
                        switch (day)
                        {
                            case "Friday":
                                price = (decimal)qty * 15m;
                                break;
                            case "Saturday":
                                price = (decimal)qty * 20m;
                                break;
                            case "Sunday":
                                price = (decimal)qty * 22.50m;
                                break;
                        }
                        price = price * 0.95m;
                    }
                    else
                    {
                        switch (day)
                        {
                            case "Friday":
                                price = (decimal)qty * 15m;
                                break;
                            case "Saturday":
                                price = (decimal)qty * 20m;
                                break;
                            case "Sunday":
                                price = (decimal)qty * 22.50m;
                                break;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
