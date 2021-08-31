using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inUnit = Console.ReadLine();
            string outUnit = Console.ReadLine();

            
            if (inUnit == "mm")
            {
                if (outUnit == "cm")
                {
                    Console.WriteLine($"{number * 0.1:f3}");
                }
                else
                {
                    Console.WriteLine($"{number * 0.001:f3}");
                }
            }
            else if (inUnit == "cm")
            {
                if (outUnit == "mm")
                {
                    Console.WriteLine($"{number * 10:f3}");
                }
                else
                {
                    Console.WriteLine($"{number * 0.01:f3}");
                }
            }
            else
            {
                if (outUnit == "cm")
                {
                    Console.WriteLine($"{number * 100:f3}");
                }
                else
                {
                    Console.WriteLine($"{number * 1000:f3}");
                }
            }
        }
    }
}
