using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(" ");
            string[] secCommand = Console.ReadLine().
                Split(" ");
            string text = Console.ReadLine();

            try
            {
                Pizza pizza = new Pizza(command[1]);
                pizza.Dough = new Dough(secCommand[1], secCommand[2], double.Parse(secCommand[3]));

                while (text != "END")
                {
                    command = text
                        .Split(" ");

                    Topping topping = new Topping(command[1], double.Parse(command[2]));
                    pizza.AddTopping(topping);

                    text = Console.ReadLine();
                }

                Console.WriteLine(pizza);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
