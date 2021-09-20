using System;

namespace SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            int carNum = int.Parse(Console.ReadLine());

            CarsColection carsColection = new CarsColection();
            for (int i = 0; i < carNum; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));

                carsColection.Cars.Add(car);
            }

            string text = Console.ReadLine();

            while (text != "End")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                carsColection.Drive(command);

                text = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, carsColection.Cars));

        }
    }
}
