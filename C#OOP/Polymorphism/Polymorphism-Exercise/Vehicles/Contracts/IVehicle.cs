using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Contracts
{
    public interface IVehicle
    {
        public double Fuel { get;}
        public double Consuption { get;}

        public  string Drive(double distance);
        public  void Refil(double fuel);
    }
}
