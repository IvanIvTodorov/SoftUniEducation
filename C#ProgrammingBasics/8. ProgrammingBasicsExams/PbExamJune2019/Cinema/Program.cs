using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            int price = 0;
            int seats = 0;

            string movie = Console.ReadLine();

            while (movie != "Movie time!")
            {
                int people = int.Parse(movie);
                seats += people;

                if (capacity < seats)
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {price} lv.");
                    Environment.Exit(0);
                }

                if (people % 3 == 0)
                {
                    price += (people - 1) * 5;
                }
                else
                {
                    price += people * 5;
                }

                movie = Console.ReadLine();
            }
            Console.WriteLine($"There are {capacity - seats} seats left in the cinema.");
            Console.WriteLine($"Cinema income - {price} lv.");
        }
    }
}
