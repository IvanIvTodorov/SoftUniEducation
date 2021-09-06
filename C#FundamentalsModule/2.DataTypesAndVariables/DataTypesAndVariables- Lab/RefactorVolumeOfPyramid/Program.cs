using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 0;  
            length = double.Parse(Console.ReadLine());
            Console.Write($"Length: ");
            double width = 0;
            width = double.Parse(Console.ReadLine());
            Console.Write($"Width: ");
            double high = 0;
            high = double.Parse(Console.ReadLine());
            Console.Write($"Height: ");
            double v = (length * width * high) / 3;
            Console.WriteLine($"Pyramid Volume: {v:f2}");
        }
    }
}
