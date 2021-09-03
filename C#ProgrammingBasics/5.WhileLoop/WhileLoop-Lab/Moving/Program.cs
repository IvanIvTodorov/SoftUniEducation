using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine()); // shirochina
            double length = double.Parse(Console.ReadLine()); // daljina
            double height = double.Parse(Console.ReadLine()); // visochina
            string boxes = Console.ReadLine();

            double roomCub = width * length * height;
            double box = 0;

            while (boxes != "Done")
            {
                double number = double.Parse(boxes);

                box += number;

                if (roomCub < box )
                {
                    Console.WriteLine($"No more free space! You need {box - roomCub} Cubic meters more.");
                    Environment.Exit(0);
                }

                boxes = Console.ReadLine();
            }
            Console.WriteLine($"{roomCub - box} Cubic meters left.");


        }
    }
}
