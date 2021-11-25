using System;

namespace Prototype
{
    class StartUp
    {
        static void Main(string[] args)
        {

            PizzaMenu pizzaMenu = new PizzaMenu();

            pizzaMenu["ForCheases"] = new Pizza("thin", "five", "big");
            pizzaMenu["Carbonara"] = new Pizza("thick", "six", "small");

            Pizza firstPizza = pizzaMenu["Carbonara"].Clone() as Pizza;
            var secondPizza = pizzaMenu["ForCheases"].Clone() as Pizza;

        }
    }
}
