using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;

            while (number % 2 != 0)
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
