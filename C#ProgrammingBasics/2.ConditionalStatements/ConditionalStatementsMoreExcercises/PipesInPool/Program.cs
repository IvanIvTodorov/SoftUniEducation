using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
      
            
                int v = int.Parse(Console.ReadLine());
                int p1 = int.Parse(Console.ReadLine());
                int p2 = int.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double litersp1 = p1 * h;
                double litersp2 = p2 * h;
                double liters = (p1 + p2) * h;
                double percentage = (liters / v) * 100;

                if (v >= liters)
                {
                    Console.WriteLine($"The pool is {percentage:f2}% full. Pipe 1: {(litersp1 / liters) * 100:f2}%. Pipe 2: {(litersp2 / liters) * 100:f2}%.");
                }
                else
                {
                    Console.WriteLine($"For {h:f2} hours the pool overflows with {liters - v} liters.");
                }
            
        }
    }

}
    

