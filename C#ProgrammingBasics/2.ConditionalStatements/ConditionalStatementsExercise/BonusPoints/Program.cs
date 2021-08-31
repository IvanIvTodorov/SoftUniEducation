using System;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            if (number <=100)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(6);
                    Console.WriteLine(number +6);
                }
                else if (number % 10 == 5)
                {
                    Console.WriteLine(7);
                    Console.WriteLine(number +7);
                }
                else
                {
                    Console.WriteLine(5);
                    Console.WriteLine(number + 5);
                }
            }
            else if (number >= 1000)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number * 0.10 + 1:f1}");
                    Console.WriteLine($"{number + (number * 0.10) + 1:f1}");
                }
                else if (number % 10 == 5)
                {
                    Console.WriteLine($"{number * 0.10 + 2:f1}");
                    Console.WriteLine($"{number + (number * 0.10) + 2:f1}");
                }
                else
                {
                    Console.WriteLine($"{number * 0.10:f1}");
                    Console.WriteLine($"{number + (number * 0.10):f1}");
                }
                
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number * 0.20 +1:f1}");
                    Console.WriteLine($"{number + (number * 0.20) + 1:f1}");
                }
                else if (number % 10 == 5)
                {
                    Console.WriteLine($"{number * 0.20 +2:f1}");
                    Console.WriteLine($"{number + (number * 0.20) + 2:f1}");
                }
                else
                {
                    Console.WriteLine($"{number * 0.20:f1}");
                    Console.WriteLine($"{number + (number * 0.20):f1}");
                }
            }
        }
    }
}
