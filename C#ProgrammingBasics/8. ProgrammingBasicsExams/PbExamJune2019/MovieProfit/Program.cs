using System;

namespace MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double percentF = (double)percent / 100;

            double allPrice = (double)days * (double)tickets * price - (((double)days * (double)tickets * price) * percentF);


            Console.WriteLine($"The profit from the movie {movie} is {allPrice:F2} lv.");
        }
    }
}
