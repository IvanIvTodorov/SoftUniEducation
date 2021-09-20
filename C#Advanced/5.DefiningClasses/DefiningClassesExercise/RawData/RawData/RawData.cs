using System;

namespace RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            int numCars = int.Parse(Console.ReadLine());

            CarColection carColection = new CarColection();

            for (int i = 0; i < numCars; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(command[1]), int.Parse(command[2]));
                Cargo cargo = new Cargo(int.Parse(command[3]), command[4]);
                Tire firstTire = new Tire(double.Parse(command[5]), int.Parse(command[6]));
                Tire secondTire = new Tire(double.Parse(command[7]), int.Parse(command[8]));
                Tire thirdTire = new Tire(double.Parse(command[9]), int.Parse(command[10]));
                Tire forthTire = new Tire(double.Parse(command[11]), int.Parse(command[12]));

                Car car = new Car(command[0], engine, cargo, firstTire, secondTire, thirdTire, forthTire);

                carColection.Cars.Add(car);
            }

            string condition = Console.ReadLine();

            carColection.FragileOrFlamable(condition, carColection.Cars);
            
        }
    }
}
