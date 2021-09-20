using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        private int capacity;
        public Parking(int capacity)
        {
            Cars = new List<Car>();
            this.capacity = capacity;
        }
        public List<Car> Cars { get; set; }
        public int Count { get; set; }

        public string AddCar(Car car)
        {
            string regPlate = car.RegistrationNumber;
            if (this.Cars.Any(n => n.RegistrationNumber == regPlate))
            {
                return "Car with that registration number, already exists!";
            }
            else if (this.Cars.Count >= this.capacity)
            {
                return "Parking is full!";
            }
            else
            {
                this.Cars.Add(car);
                this.Count = this.Cars.Count;
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }

        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.Cars.Any(n => n.RegistrationNumber == registrationNumber))
            {
                int index = this.Cars.FindIndex(n => n.RegistrationNumber == registrationNumber);
                this.Cars.RemoveAt(index);
                this.Count = this.Cars.Count;
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {

            int index = this.Cars.FindIndex(n => n.RegistrationNumber == registrationNumber);
            return this.Cars[index];

        }

        public void RemoveSetOfRegistrationNumber(List<string> registartionNumbers)
        {
            foreach (var plate in registartionNumbers)
            {
                if (this.Cars.Any(n => n.RegistrationNumber == plate))
                {
                    int index = this.Cars.FindIndex(n => n.RegistrationNumber == plate);
                    this.Cars.RemoveAt(index);
                }
            }
            this.Count = this.Cars.Count;
        }
    }
}
