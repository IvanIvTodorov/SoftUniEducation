using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string barcodPatt = @"\@\#+([A-Z][A-Za-z0-9]{4,}[A-Z])\@\#+";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex reg = new Regex(barcodPatt);

                if (reg.IsMatch(input))
                {
                    string current = reg.Match(input).ToString();
                    string group = string.Empty;
                    for (int k = 0; k < current.Length; k++)
                    {
                        if (char.IsDigit(current[k]))
                        {
                            group += current[k];
                        }
                    }
                    if (group != string.Empty)
                    {
                        Console.WriteLine($"Product group: {group}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
