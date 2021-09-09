using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            MathPower(first, second);
        }
        static void MathPower(double first, int second)
        {
            Console.WriteLine(Math.Pow(first, second));
        }
    }
}
