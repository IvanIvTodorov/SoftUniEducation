using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while (input != "End")
            {
                string[] text = input
                    .Split();

                switch (text[0])
                {
                    case "truck":
                        Truck truck = new Truck(text[0], text[1], text[2], double.Parse(text[3]));
                        trucks.Add(truck);
                        break;
                    case "car":
                        Car car = new Car(text[0], text[1], text[2], double.Parse(text[3]));
                        cars.Add(car);
                        break;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                if (trucks.Any(n => n.Model == input))
                {
                    int index = trucks.FindIndex(n => n.Model == input);
                    Console.WriteLine(trucks[index]);
                }
                else if (cars.Any(n => n.Model == input))
                {
                    int index = cars.FindIndex(n => n.Model == input);
                    Console.WriteLine(cars[index]);
                }

                input = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {cars.Select(n => n.Horsepower).Average():f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucks.Select(n => n.Horsepower).Average():f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }
    }
    class Truck
    {

        public Truck(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine($"Type: Truck");
            text.AppendLine($"Model: {Model}");
            text.AppendLine($"Color: {Color}");
            text.Append($"Horsepower: {Horsepower}");

            return text.ToString();
        }

    }
    class Car
    {

        public Car(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine($"Type: Car");
            text.AppendLine($"Model: {Model}");
            text.AppendLine($"Color: {Color}");
            text.Append($"Horsepower: {Horsepower}");

            return text.ToString();
        }

    }

}
