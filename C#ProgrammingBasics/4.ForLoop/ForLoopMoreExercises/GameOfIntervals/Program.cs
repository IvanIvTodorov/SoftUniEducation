using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int ways = int.Parse(Console.ReadLine());

            double result = 0;
            int num1 = 0;
            int num2 = 0;
            int num3= 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            double num1P = 0;
            double num2P = 0;
            double num3P = 0;
            double num4P = 0;
            double num5P = 0;
            double num6P = 0;
            double numbersAll = 0;

            for (int i = 1; i <= ways; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9 )
                {
                    num1 += 1;
                    num1P = number * 0.20;
                    result += num1P;
                    numbersAll += 1;
                }
                else if (number >= 10 && number <= 19)
                {
                    num2 += 1;
                    num2P = number * 0.30;
                    result += num2P;
                    numbersAll += 1;
                }
                else if (number >= 20 && number <= 29)
                {
                    num3 += 1;
                    num3P = number * 0.40;
                    result += num3P;
                    numbersAll += 1;
                }
                else if (number >= 30 && number <= 39)
                {
                    num4 += 1;
                    num4P = 50;
                    result += num4P;
                    numbersAll += 1;
                }
                else if (number >= 40 && number <= 50)
                {
                    num5 += 1;
                    num5P = 100;
                    result += num5P;
                    numbersAll += 1;
                }
                else
                {
                    num6 += 1;
                    num6P = result / 2;
                    result = num6P;
                    numbersAll += 1;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {num1 / numbersAll *100:f2}%");
            Console.WriteLine($"From 10 to 19: {num2 / numbersAll *100:f2}%");
            Console.WriteLine($"From 20 to 29: {num3 / numbersAll *100:f2}%");
            Console.WriteLine($"From 30 to 39: {num4 / numbersAll *100:f2}%");
            Console.WriteLine($"From 40 to 50: {num5 / numbersAll *100:f2}%");
            Console.WriteLine($"Invalid numbers: {num6 / numbersAll *100:f2}%");
        }
    }
}
