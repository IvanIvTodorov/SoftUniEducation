using System;
using System.Linq;
using System.Numerics;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal total = 0.0m;
            decimal number = 0;
            int firstCommand = 0;
            int secCommand = 0;
           
            for (int i = 0; i < text.Length; i++)
            {
                string current = text[i];
                string conc = string.Empty;

                for (int j = 0; j < current.Length; j++)
                {
                    if (j == 0 || j == current.Length - 1)
                    {
                        continue;                   
                    }
                    else
                    {
                        conc += current[j].ToString();
                    }                   
                }
                number = int.Parse(conc);
                if (char.IsUpper(text[i].FirstOrDefault()))
                {
                    firstCommand = text[i].FirstOrDefault() - 64;
                    number = number / firstCommand;
                }
                else
                {
                    firstCommand = text[i].FirstOrDefault() - 96;
                    number = number * firstCommand;

                }
                if (char.IsUpper(text[i].LastOrDefault()))
                {
                    secCommand = text[i].LastOrDefault() - 64;
                    number = number - secCommand;

                }
                else
                {
                    secCommand = text[i].LastOrDefault() - 96;
                    number = number + secCommand;
                }

                total += number;
            }
            Console.WriteLine($"{total:f2}");           
        }
    }
}
