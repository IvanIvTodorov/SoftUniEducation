using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(double fuel,double consuption)
            :this()
        {
            Fuel = fuel;
            Consuption = consuption;
        }
        public double Fuel { get; protected set; }

        public double Consuption { get; protected set; }

        public abstract string Drive(double distance);

        public abstract void Refil(double fuel);
       
    }
}
