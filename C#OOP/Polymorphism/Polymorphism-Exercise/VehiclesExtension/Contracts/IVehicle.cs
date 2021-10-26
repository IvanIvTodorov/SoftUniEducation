using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Contracts
{
    public interface IVehicle
    {
        public double Capacity { get; }
        public double Fuel { get;}
        public double Consuption { get;}

        public  string Drive(double distance);
        public  void Refil(double fuel);
    }
}
