    using System;

    namespace SquareTrapezoid
    {
        class Program
        {
            static void Main(string[] args)
            {
                double b1 = double.Parse(Console.ReadLine());
                double b2 = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double hH = h / 2;
                double square = (b1 + b2) * hH ;

                Console.WriteLine($"{square:f2}");
            }
        }
    }
