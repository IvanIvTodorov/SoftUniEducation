using System;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> phrase = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            List<string> events = new List<string>()
            {
               "Now I feel good.",
               "I have succeeded with this product.",
               "Makes miracles. I am happy of the results!",
               "I cannot believe but now I feel awesome.",
               "Try it yourself, I am very satisfied.",
               "I feel great!"
            };
            List<string> authors = new List<string>()
            {
                "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie", 
                "Eva"
            };
            List<string> cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random rnd = new Random();

            int messages = int.Parse(Console.ReadLine());

            for (int i = 0; i < messages; i++)
            {
                int indexPhrases = rnd.Next(phrase.Count);
                int indexEvents = rnd.Next(events.Count);
                int indexAuthors = rnd.Next(authors.Count);
                int indexCities = rnd.Next(cities.Count);

                Console.WriteLine($"{phrase[indexPhrases]} {events[indexEvents]} {authors[indexAuthors]} - {cities[indexCities]}.");
            }
            
        }

    }
    
}
