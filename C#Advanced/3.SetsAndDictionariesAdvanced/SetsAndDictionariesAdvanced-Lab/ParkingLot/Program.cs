using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "IN")
                {
                    cars.Add(command[1]);
                }
                else
                {
                    cars.Remove(command[1]);
                }

                input = Console.ReadLine();
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }           
        }
    }
}
