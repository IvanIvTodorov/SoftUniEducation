using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string namePattern = @"%(?<name>[A-Z][a-z]+)%";
            string productPattern = @"<(?<product>\w+)>";
            string qtyPatern = @"\|(?<qty>[0-9]+)\|";
            string pricePattern = @"(?<price>[0-9]+?\.?[0-9]+?)\$";

            Dictionary<string, double> persons = new Dictionary<string, double>();

            while (input != "end of shift")
            {
                Regex regex = new Regex(namePattern);
                var one = regex.Matches(input);
                regex = new Regex(productPattern);
                var two = regex.Matches(input);
                regex = new Regex(qtyPatern);
                var three = regex.Matches(input);
                regex = new Regex(pricePattern);
                var four = regex.Matches(input);

                string name = string.Empty;
                string product = string.Empty;
                int qty = 0;
                double price = 0;
                if (one.Count > 0 && two.Count > 0 && three.Count > 0 && four.Count > 0)
                {
                    foreach (Match item in one)
                    {
                        name = item.Groups["name"].Value;
                    }
                    foreach (Match item in two)
                    {
                        product = item.Groups["product"].Value;
                    }
                    foreach (Match item in three)
                    {
                        qty = int.Parse(item.Groups["qty"].Value);
                    }
                    foreach (Match item in four)
                    {
                        price = double.Parse(item.Groups["price"].Value);
                    }
                    if (!persons.ContainsKey(name))
                    {
                        persons.Add(name, (qty * price));
                    }
                    else
                    {
                        persons[name] += (qty * price);
                    }
                    Console.WriteLine($"{name}: {product} - {qty * price:F2}");
                }
                

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {persons.Values.Sum():F2}");
        }
    }
}
