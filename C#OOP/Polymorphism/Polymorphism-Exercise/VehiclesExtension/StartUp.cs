using System;
using System.Collections.Generic;
using VehiclesExtension.Contracts;
using VehiclesExtension.Models;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = SplitInput();
            string[] truckInfo = SplitInput();
            string[] busInfo = SplitInput();

            double carFuel = double.Parse(carInfo[1]);
            double carConsuption = double.Parse(carInfo[2]);
            double carCapacity = double.Parse(carInfo[3]);
            double truckFuel = double.Parse(truckInfo[1]);
            double truckConsuption = double.Parse(truckInfo[2]);
            double truckCapacity = double.Parse(truckInfo[3]);
            double busFuel = double.Parse(busInfo[1]);
            double busConsuption = double.Parse(busInfo[2]);
            double busCapacity = double.Parse(busInfo[3]);


            IVehicle car = new Car(carFuel, carConsuption,carCapacity);
            IVehicle truck = new Truck(truckFuel, truckConsuption,truckCapacity);
            Bus bus = new Bus(busFuel, busConsuption, busCapacity);
            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(bus);

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
                else if (vehicle == "Truck")
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
                else
                {
                    if (toDo == "Drive")
                    {
                        Console.WriteLine(bus.Drive(value));
                    }
                    else if (toDo == "DriveEmpty")
                    {
                        Console.WriteLine(bus.Drive(value, toDo));
                    }
                    else
                    {
                        bus.Refil(value);
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
