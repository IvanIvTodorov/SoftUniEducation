using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\||#)(?<name>[A-Za-z\s]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<cal>[0-9]{1,6})\1";

            Regex reg = new Regex(pattern);

            MatchCollection matches = reg.Matches(input);

            int calories = 0;
            foreach (Match item in matches)
            {
                calories += int.Parse(item.Groups["cal"].Value);
            }
            Console.WriteLine($"You have food to last you for: {calories / 2000} days!");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups["name"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["cal"].Value}");
            }
        }
    }
}
