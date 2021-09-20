using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Tire[]> colectionOfTires = new List<Tire[]>();

            while (input != "No more tires" )
            {
                string[] tiresValues = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Tire[] tires = new Tire[]
                {
                    new Tire(int.Parse(tiresValues[0]), double.Parse(tiresValues[1])),
                    new Tire(int.Parse(tiresValues[2]), double.Parse(tiresValues[3])),
                    new Tire(int.Parse(tiresValues[4]), double.Parse(tiresValues[5])),
                    new Tire(int.Parse(tiresValues[6]), double.Parse(tiresValues[7])),
                 
                };
                colectionOfTires.Add(tires);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            List<Engine> engines = new List<Engine>();

            while (input != "Engines done")
            {
                string[] engineValues = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(engineValues[0]), double.Parse(engineValues[1]));

                engines.Add(engine);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            List<Car> cars = new List<Car>();

            while (input != "Show special")
            {
                string[] carValues = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(
                    carValues[0],
                    carValues[1],
                    int.Parse(carValues[2]),
                    double.Parse(carValues[3]),
                    double.Parse(carValues[4]),
                    engines[int.Parse(carValues[5])],
                    colectionOfTires[int.Parse(carValues[6])]
                    );

                cars.Add(car);

                input = Console.ReadLine();
            }           

            cars = cars.Where(car => car.Year > 2016
            && car.Engine.HorsePower > 330
            && car.Tires.Sum(x => x.Pressure) >= 9
            && car.Tires.Sum(x => x.Pressure) <= 10)
            .ToList();

            foreach (var unit in cars)
            {
               unit.Drive(20);
               Console.WriteLine(unit.WhoAmI());
            }
        }
    }
}
