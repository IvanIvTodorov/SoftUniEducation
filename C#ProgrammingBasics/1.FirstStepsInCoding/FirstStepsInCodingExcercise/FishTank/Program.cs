using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = lenght * width * high * (1 - percentage / 100);
            double volumeDm = volume * 0.001;

            Console.WriteLine(volumeDm);
        }
    }
}
