using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            decimal years = centuries * 100;
            int days = Convert.ToInt32(Math.Floor(years * 365.2422m));
            int hours = days * 24;
            long minutes = hours * 60;


            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
