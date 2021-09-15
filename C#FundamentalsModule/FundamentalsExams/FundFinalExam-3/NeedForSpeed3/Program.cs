using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car();

                car.Miles = int.Parse(input[1]);
                car.Fuel = int.Parse(input[2]);

                cars.Add(input[0], car);
            }

            string text = Console.ReadLine();

            while (text != "Stop")
            {
                string[] command = text.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Drive")
                {
                    if (cars[command[1]].Fuel >= int.Parse(command[3]))
                    {
                        cars[command[1]].Fuel -= int.Parse(command[3]);
                        cars[command[1]].Miles += int.Parse(command[2]);

                        Console.WriteLine($"{command[1]} driven for {command[2]} kilometers. {command[3]} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");     
                    }
                    if (cars[command[1]].Miles >= 100000)
                    {
                        cars.Remove(command[1]);
                        Console.WriteLine($"Time to sell the {command[1]}!");
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (cars[command[1]].Fuel + int.Parse(command[2]) <= 75)
                    {
                        cars[command[1]].Fuel += int.Parse(command[2]);
                        Console.WriteLine($"{command[1]} refueled with {command[2]} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} refueled with {75 - cars[command[1]].Fuel} liters");
                        cars[command[1]].Fuel = 75;                     
                    }
                }
                else if (command[0] == "Revert")
                {
                    if (cars[command[1]].Miles - int.Parse(command[2]) < 10000)
                    {
                        cars[command[1]].Miles = 10000;
                    }
                    else
                    {
                        cars[command[1]].Miles -= int.Parse(command[2]);
                        Console.WriteLine($"{command[1]} mileage decreased by {command[2]} kilometers");
                    }
                }

                text = Console.ReadLine();
            }

            foreach (var item in cars.OrderByDescending(n => n.Value.Miles).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Miles} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
    class Car
    {
        public int Miles { get; set; }
        public int Fuel { get; set; }
    }
}
