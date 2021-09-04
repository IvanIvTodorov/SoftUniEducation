using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double student = 0;
            double standard = 0;
            double kid = 0;
            double people = 0;
            double Allpeople = 0;

            while (movie != "Finish")
            {
                double places = int.Parse(Console.ReadLine());
                for (int i = 1; i <= places; i++)
                {
                    string ticket = Console.ReadLine();
                    
                    if (ticket == "End")
                    {
                        Console.WriteLine($"{movie} - {people / places * 100:F2}% full.");
                        people = 0;
                        break;
                    }
                    else if (ticket == "student")
                    {
                        student++;
                    }
                    else if (ticket == "standard")
                    {
                        standard++;
                    }
                    else
                    {
                        kid++;
                    }
                    people++;
                    Allpeople++;
                    if (i == places)
                    {
                        Console.WriteLine($"{movie} - {people / places * 100:F2}% full.");
                        people = 0;
                    }
                }
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {Allpeople}");
            Console.WriteLine($"{student / Allpeople * 100:f2}% student tickets.");
            Console.WriteLine($"{standard / Allpeople * 100:f2}% standard tickets.");
            Console.WriteLine($"{kid / Allpeople * 100:F2}% kids tickets.");
        }
    }
}

