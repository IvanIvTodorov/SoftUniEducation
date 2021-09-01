using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            
            switch (symbol)
            {
                case "+":
                    if ((n1 + n2) % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {n1 + n2} - even");
                    }
                    break;
                case "-":
                    if ((n1 - n2) % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2} - even");
                    }
                    break;
                case "*":
                    if ((n1 * n2) % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2} - even");
                    }
                    break;
            }
            switch (symbol)
            {
                case "+":
                    if ((n1 + n2) % 2 != 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {n1 + n2} - odd");
                    }
                    break;
                case "-":
                    if ((n1 - n2) % 2 != 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2} - odd");
                    }
                    break;
                case "*":
                    if ((n1 * n2) % 2 != 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2} - odd");
                    }
                    break;
            }
            switch (symbol)
            {
                case "/":
                    if (n2 != 0)
                    {
                        double result = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:F2}");
                    }
                    break;
                case "%":
                    if (n2 != 0)
                    {
                        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                    }
                    break;
            }
            switch (symbol)
            {
                case "/":
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
            }
        }
    }
}
