using System;

namespace GeorgeBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPages = int.Parse(Console.ReadLine());
            double pages = double.Parse(Console.ReadLine());
            int nDays = int.Parse(Console.ReadLine());
            
            double hoursBook = nPages / pages;

            Console.WriteLine($"{hoursBook / nDays}");
        }
    }
}
