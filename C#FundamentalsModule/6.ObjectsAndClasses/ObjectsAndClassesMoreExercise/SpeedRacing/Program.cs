using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
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

                Car car = new Car(text[0], double.Parse(text[1]), double.Parse(text[2]));

                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] text = input.Split();

                if (cars.Any(n => n.Model == text[1]))
                {
                    int index = cars.FindIndex(n => n.Model == text[1]);
                    if (cars[index].Fuel - (double.Parse(text[2]) * cars[index].PerKm) >= 0)
                    {
                        cars[index].Fuel -= double.Parse(text[2]) * cars[index].PerKm;
                        cars[index].Distance.Add(double.Parse(text[2]));
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }

                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
    class Car
    {
        public Car(string model, double fuel, double perKm)
        {
            Model = model;
            Fuel = fuel;
            PerKm = perKm;
            Distance = new List<double>();
        }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double PerKm { get; set; }
        public List<double> Distance { get; set; }

        public override string ToString()
        {
            
            return $"{Model} {Fuel:F2} {Distance.Sum()}"; 
        }

    }

}
