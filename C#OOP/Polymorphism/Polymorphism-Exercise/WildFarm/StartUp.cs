using System;
using System.Collections.Generic;
using WildFarm.Models;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Animal> animals = new List<Animal>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = input[0];
                string name = input[1];
                double weight = double.Parse(input[2]);
                Animal animal = null;

                if (type == "Hen")
                {
                    double wingSize = double.Parse(input[3]);

                    animal = new Hen(name, weight, wingSize);
                }
                else if (type == "Owl")
                {
                    double wingSize = double.Parse(input[3]);

                    animal = new Owl(name, weight, wingSize);
                }
                else if (type == "Mouse")
                {
                    string livingRegion = input[3];

                    animal = new Mouse(name, weight, livingRegion);
                }
                else if (type == "Dog")
                {
                    string livingRegion = input[3];

                    animal = new Dog(name, weight, livingRegion);
                }
                else if (type == "Cat")
                {
                    string livingRegion = input[3];
                    string breed = input[4];

                    animal = new Cat(name, weight, livingRegion, breed);
                }
                else if (type == "Tiger")
                {
                    string livingRegion = input[3];
                    string breed = input[4];

                    animal = new Tiger(name, weight, livingRegion, breed);                   
                }

                Console.WriteLine(animal.MakeSoud());

                string[] foodInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                type = foodInput[0];
                int quantity = int.Parse(foodInput[1]);
                Food food = null;

                if (type == "Vegetable")
                {
                    food = new Vegetable(quantity);
                }
                else if (type == "Fruit")
                {
                    food = new Fruit(quantity);
                }
                else if (type == "Meat")
                {
                    food = new Meat(quantity);
                }
                else if (type == "Seeds")
                {
                    food = new Seeds(quantity);
                }

                animal.Eat(food);
                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

        }
    }
}
