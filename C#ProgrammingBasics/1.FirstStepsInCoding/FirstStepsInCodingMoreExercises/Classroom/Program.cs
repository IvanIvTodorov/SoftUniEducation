using System;

namespace Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()); // daljina 
            double h = double.Parse(Console.ReadLine()); // shirochina

            double width = h * 100; // shirochina
            double lenght = w * 100; // daljina

            double placesW = ((int)width - 100) / 70; 
            double placesL = (int)lenght / 120;

            double placesAll = placesW * placesL - 3;

            Console.WriteLine(placesAll);

        }
    }
}
