using ExplicitInterfaces.Contracts;
using System;
using System.Collections.Generic;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            while ((text = Console.ReadLine()) != "End")
            {
                string[] input = text
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                IPerson citizen = new Citizen(name,country,age);
                IResident resident = new Citizen(name, country, age);

                Console.WriteLine(citizen.GetName());
                Console.WriteLine(resident.GetName());
            }

        }
    }
}
