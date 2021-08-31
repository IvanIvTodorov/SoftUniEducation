using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int othersA = int.Parse(Console.ReadLine());

            double a = 2.5;
            int b = 4;

            double result1 = dogs * a;
            double result2 = othersA * b;
            double result = result1 + result2;

            Console.WriteLine($"{result} lv.");
        }
    }
}
