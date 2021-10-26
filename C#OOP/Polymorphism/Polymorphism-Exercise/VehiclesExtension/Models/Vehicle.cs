using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Contracts;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double capacity;

        public Vehicle(double fuel, double consuption, double capacity)
        {
            Fuel = fuel;
            Consuption = consuption;
            Capacity = capacity;
        }
        public double Fuel { get; protected set; }

        public double Consuption { get; protected set; }

        public double Capacity
        {
            get
            {
                return capacity;
            }
            protected set
            {
                if (Fuel > value)
                {
                    Fuel = 0;
                }
                capacity = value;
            }

        }

        public abstract string Drive(double distance);

        public abstract void Refil(double fuel);

    }
}
