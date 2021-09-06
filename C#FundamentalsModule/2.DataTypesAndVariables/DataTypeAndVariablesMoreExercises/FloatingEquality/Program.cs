using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            bool diff = Math.Abs(first - second) < 0.000001;

            Console.WriteLine(diff);
            
        }
    }
}
