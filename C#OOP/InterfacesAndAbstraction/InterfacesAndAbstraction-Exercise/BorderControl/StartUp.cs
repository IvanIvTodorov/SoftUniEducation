using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Length > 3)
                {
                    var citizen = new Citizen(command[0], command[1], command[2], command[3]);
                    citizens.Add(citizen);
                }
                else
                {
                    var rebel = new Rebel(command[0], command[1], command[2]);
                    rebels.Add(rebel);
                }

            }
            string text = Console.ReadLine();

            while (text != "End")
            {
                if (rebels.Any(n => n.Name == text))
                {
                    int index = rebels.FindIndex(n => n.Name == text);
                    rebels[index].BuyFood();
                }
                if (citizens.Any(n => n.Name == text))
                {
                    int index = citizens.FindIndex(n => n.Name == text);
                    citizens[index].BuyFood();
                }

                text = Console.ReadLine();
            }

            int sum = 0;
            foreach (var item in citizens)
            {
                sum += item.Food;
            }
            foreach (var item in rebels)
            {
                sum += item.Food;
            }
            Console.WriteLine(sum);
        }
    }
}
