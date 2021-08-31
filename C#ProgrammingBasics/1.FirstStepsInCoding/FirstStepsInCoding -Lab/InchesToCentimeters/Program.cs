using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            double a = 2.54;

            double result = number * a;

            Console.WriteLine(result);
        }
    }
}
