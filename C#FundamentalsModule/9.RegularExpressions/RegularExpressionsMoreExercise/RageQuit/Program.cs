using System;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            int symbols = 0;
            string repeat = @"[^0-9]+";
            string timesRepeat = @"[0-9]+";

            StringBuilder output = new StringBuilder();

            var words = Regex.Matches(input, repeat);
            var numbers = Regex.Matches(input, timesRepeat);

            int count = 0;
            foreach (var item in words)
            {
                string current = item.ToString();
                for (int i = 0; i < int.Parse(numbers[count].ToString()); i++)
                {
                    output.Append(current);
                }
                count++;
            }

            string contain = string.Empty;
            foreach (char item in output.ToString())
            {
                if (!contain.Contains(item))
                {
                    contain += item.ToString();
                    symbols++;
                }
            }
            Console.WriteLine($"Unique symbols used: {symbols}");
            Console.WriteLine(output);
        }
    }
}
