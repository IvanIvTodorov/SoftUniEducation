using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < number; i++)
            {
                string[] text = Console.ReadLine().Split();

                Car car = new Car(text[0]);

                car.Engine.Speed = int.Parse(text[1]);
                car.Engine.Power = int.Parse(text[2]);
                car.Cargo.Weight = int.Parse(text[3]);
                car.Cargo.Type = text[4];

                cars.Add(car);           
            }

            string type = Console.ReadLine();

            if (type == "fragile")
            {
                foreach (Car item in cars.Where(n => n.Cargo.Type == "fragile").Where(n => n.Cargo.Weight < 1000))
                {
                    Console.WriteLine(item.Model);
                }
            
            }
            else if (type == "flamable")
            {               
                foreach (Car item in cars.Where(n => n.Cargo.Type =="flamable").Where(n => n.Engine.Power > 250))
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
    class Car
    {
        public Car(string model)
        {
            Model = model;
            Engine = new Engine();
            Cargo = new Cargo();
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

    }
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }

    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

    }
}
