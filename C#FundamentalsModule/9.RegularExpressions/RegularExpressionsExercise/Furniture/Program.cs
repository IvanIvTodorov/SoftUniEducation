using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {         
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            while (input != "Purchase")
            {
                output.AppendLine(input);

               input = Console.ReadLine();
            }     
            
            string pattern = @">>(?<item>\w+)<<(?<price>[0-9]+\.?[0-9]+?)!(?<qty>[0-9]+)\b";
            MatchCollection matches = Regex.Matches(output.ToString(), pattern);

            Console.WriteLine("Bought furniture:");

            decimal sum = 0;
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Groups["item"].Value);

                sum += decimal.Parse(item.Groups["price"].Value) * int.Parse(item.Groups["qty"].Value);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }

}
