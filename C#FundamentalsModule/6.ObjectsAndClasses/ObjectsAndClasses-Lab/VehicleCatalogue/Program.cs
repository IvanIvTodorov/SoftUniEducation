using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<Car> allCars = new List<Car>();
            List<Truck> allTrucks = new List<Truck>();

            while (text != "end")
            {
                string[] input = Type(text);

                switch (input[0])
                {
                    case "Car":
                        Car cars = new Car()
                        {
                            Brand = input[1],
                            Model = input[2],
                            HorsePower = int.Parse(input[3])
                        };
                        allCars.Add(cars);
                        break;
                    case "Truck":
                        Truck trucks = new Truck()
                        {                        
                                Brand = input[1],
                                Model = input[2],
                                Weight = int.Parse(input[3])
                        };
                        allTrucks.Add(trucks);
                        break;
                }
                text = Console.ReadLine();
            }


            Console.WriteLine("Cars:");
            foreach (Car item in allCars.OrderBy(n => n.Brand))
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Truck item in allTrucks.OrderBy(n => n.Brand))
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
            }


        }
        private static string[] Type(string text)
        {
            string[] input = text.Split("/");

            return input;
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
}


