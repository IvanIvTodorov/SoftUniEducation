using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class CarSalesman
    {
        static void Main(string[] args)
        {
            int numOfItems = int.Parse(Console.ReadLine());
            List<string> text = null;

            EnginesCollection engines = new EnginesCollection();

            for (int i = 0; i < numOfItems; i++)
            {
                text = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (text.Count < 3)
                {
                    Engine engine = new Engine(text[0], text[1]);
                    engines.Engines.Add(engine);
                    continue;
                }

                bool isDigit = text[2].All(char.IsDigit);

                if (!isDigit && text.Count == 3)
                {
                    text.Insert(2, "n/a");
                }
                if (text.Count == 3)
                {
                    Engine engine = new Engine(text[0], text[1], text[2]);
                    engines.Engines.Add(engine);
                }
                else
                {
                    Engine engine = new Engine(text[0], text[1], text[2], text[3]);
                    engines.Engines.Add(engine);
                }               
            }

            numOfItems = int.Parse(Console.ReadLine());
            CarsColection cars = new CarsColection();

            for (int i = 0; i < numOfItems; i++)
            {
                text = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int indexOfEngine = engines.Engines.FindIndex(n => n.Model == text[1]);

                if (text.Count < 3)
                {
                    Car car = new Car(text[0], engines.Engines[indexOfEngine]);
                    cars.Cars.Add(car);
                    continue;
                }

                bool isDigit = text[2].All(char.IsDigit);

                if (!isDigit && text.Count == 3)
                {
                    text.Insert(2, "n/a");
                }
                if (text.Count == 3)
                {
                    Car car = new Car(text[0], engines.Engines[indexOfEngine], text[2]);
                    cars.Cars.Add(car);
                }
                else
                {
                    Car car = new Car(text[0], engines.Engines[indexOfEngine], text[2], text[3]);
                    cars.Cars.Add(car);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars.Cars));
        }
    }
}
