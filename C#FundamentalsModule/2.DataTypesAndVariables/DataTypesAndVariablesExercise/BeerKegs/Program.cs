using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());

            double volumeMax = 0;
            string biggest = "";

            for (int i = 1; i <= qty; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

               double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > volumeMax)
                {
                    volumeMax = volume;
                    biggest = model;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
