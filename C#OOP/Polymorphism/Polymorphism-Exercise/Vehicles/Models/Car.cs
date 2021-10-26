using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double INCREASE_FUEL = 0.9;

        public Car(double fuel, double consuption) 
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
            Fuel += fuel;
        }

        public override string ToString()
        {
            return $"Car: {Fuel:F2}";
        }
    }
}
