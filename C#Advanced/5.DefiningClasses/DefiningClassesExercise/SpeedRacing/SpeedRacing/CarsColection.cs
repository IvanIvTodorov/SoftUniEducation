using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeedRacing
{
    public class CarsColection
    {
        public CarsColection()
        {
            Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }

        public void Drive(string[] command )
        {
            if (this.Cars.Any(n => n.Model == command[1]))
            {
                int index = this.Cars.FindIndex(n => n.Model == command[1]);

                if (this.Cars[index].FuelAmount - (double.Parse(command[2]) * this.Cars[index].FuelPerKm) >= 0)
                {
                    this.Cars[index].TraveledDistance += double.Parse(command[2]);
                    this.Cars[index].FuelAmount -= double.Parse(command[2]) * this.Cars[index].FuelPerKm;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }       
        }

    }
}
