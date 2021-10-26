using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private const double INCREASE_FUEL = 0.9;

        public Car(double fuel, double consuption, double capacity) 
            : base(fuel, consuption, capacity)
        {
        }

        public override string Drive(double distance)
        {
            string result = $"{this.GetType().Name} needs refueling";
            double fuelDrive = distance * Consuption + distance * INCREASE_FUEL;

            if (Fuel >= fuelDrive)
            {
                Fuel -= fuelDrive;
                result = $"{this.GetType().Name} travelled {distance} km";
            }
            
            return result;
        }

        public override void Refil(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (Fuel + fuel > Capacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                Fuel += fuel;
            }
        }

        public override string ToString()
        {
            return $"Car: {Fuel:F2}";
        }
    }
}
