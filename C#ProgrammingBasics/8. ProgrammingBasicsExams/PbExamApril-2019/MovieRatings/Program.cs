using System;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());

            string best = "";
            string low = "";

            double min = double.MaxValue;
            double max = 0;
            double count = 0;
            for (int i = 1; i <= movies; i++)
            {
                string text = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if (rating > max)
                {
                    max = rating;
                    best = text;
                }
                if (rating < min)
                {
                    min = rating;
                    low = text;
                }
                count += rating;
            }
            double average = count / movies;

            Console.WriteLine($"{best} is with highest rating: {max:f1}");
            Console.WriteLine($"{low} is with lowest rating: {min:F1}");
            Console.WriteLine($"Average rating: {average:F1}");
        }
    }
}
