using System;
using System.Collections.Generic;
using Vehicles.Contracts;
using Vehicles.Models;

namespace Vehicles
{
    public 
        
        class StartUp
    {
        static void Main(string[] args)
        {
            string[] CarInfo = SplitInput();
            string[] TruckInfo = SplitInput();

            double carFuel = double.Parse(CarInfo[1]);
            double carConsuption = double.Parse(CarInfo[2]);
            double truckFuel = double.Parse(TruckInfo[1]);
            double truckConsuption = double.Parse(TruckInfo[2]);

            IVehicle car = new Car(carFuel, carConsuption);
            IVehicle truck = new Truck(truckFuel, truckConsuption);
            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(truck);

            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {

                string[] input = SplitInput();

                string toDo = input[0];
                string vehicle = input[1];
                double value = double.Parse(input[2]);

                if (vehicle == "Car")
                {
                    if (toDo == "Drive")
                    {
                        Console.WriteLine(car.Drive(value));
                    }
                    else
                    {
                        car.Refil(value);
                    }
                }
                else
                {
                    if (toDo == "Drive")
                    {
                        Console.WriteLine(truck.Drive(value));
                    }
                    else
                    {
                        truck.Refil(value);
                    }
                }

            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        private static string[] SplitInput()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
