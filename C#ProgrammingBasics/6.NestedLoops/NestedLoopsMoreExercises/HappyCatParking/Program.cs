using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sum = 0;
            double totalsum = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int c = 1; c <= hours; c++)
                {
                    if (i % 2 != 0 && c % 2 == 0)
                    {
                        sum += 1.25;
                    }
                    else if (i % 2 == 0 && c % 2 != 0)
                    {
                        sum += 2.50;
                    }
                    else
                    {
                        sum += 1.00;
                    }
                }
                Console.WriteLine($"Day: {i} - {sum:F2} leva");
                totalsum += sum;
                sum = 0; 
            }
            Console.WriteLine($"Total: {totalsum:F2} leva");
        }
    }
}
