using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            Queue<string> passed = new Queue<string>();
            Queue<string> cars = new Queue<string>();
            while (text != "end")
            {

                if (text == "green")
                {
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }

                        string current = cars.Dequeue();
                        Console.WriteLine($"{current} passed!");
                        passed.Enqueue(current);
                        
                    }
                }
                else
                {
                    cars.Enqueue(text);
                }

                text = Console.ReadLine();
            }
            Console.WriteLine($"{passed.Count} cars passed the crossroads.");
        }
    }
}
