using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double INCREASE_FUEL = 1.6;
        private const double FUEL_LOST = 0.95;

        public Truck(double fuel, double consuption) 
            : base(fuel, consuption)
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
            Fuel += fuel * FUEL_LOST;
        }
        public override string ToString()
        {
            return $"Truck: {Fuel:F2}";
        }
    }
}
