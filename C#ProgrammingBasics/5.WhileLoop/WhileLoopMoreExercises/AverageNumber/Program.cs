using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            double rating = 0;
            double average = 0;

            for (int i = 0; i < n; i++)
            {
                rating = double.Parse(Console.ReadLine());
                count++;
                average += rating;
            }
            Console.WriteLine($"{average / count:f2}");
        }
    }
}
