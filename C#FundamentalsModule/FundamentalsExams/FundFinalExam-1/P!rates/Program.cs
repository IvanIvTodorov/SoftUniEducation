using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string text = Console.ReadLine();

            Dictionary<string, Place> places = new Dictionary<string, Place>();
            Place place = new Place();

            while (text != "Sail")
            {
                string[] command = text.Split("||", StringSplitOptions.RemoveEmptyEntries);

                if (!places.ContainsKey(command[0]))
                {
                    place = new Place();

                    place.Gold = int.Parse(command[2]);
                    place.Population = int.Parse(command[1]);

                    places.Add(command[0], place);
                }
                else
                {                   
                    places[command[0]].Gold += int.Parse(command[2]);
                    places[command[0]].Population += int.Parse(command[1]);
                }

                text = Console.ReadLine();
            }

            text = Console.ReadLine();

            while (text != "End")
            {
                string[] command = text.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Plunder")
                {
                    if (places.ContainsKey(command[1]))
                    {
                        places[command[1]].Gold -= int.Parse(command[3]);
                        places[command[1]].Population -= int.Parse(command[2]);

                        Console.WriteLine($"{command[1]} plundered! {command[3]} gold stolen, {command[2]} citizens killed.");

                        if (places[command[1]].Gold <= 0 || places[command[1]].Population <= 0)
                        {
                            places.Remove(command[1]);
                            Console.WriteLine($"{command[1]} has been wiped off the map!");
                        }
                    }
                }
                else if (command[0] == "Prosper")
                {
                    if (!(int.Parse(command[2]) < 0))
                    {
                        places[command[1]].Gold += int.Parse(command[2]);

                        Console.WriteLine($"{command[2]} gold added to the city treasury. {command[1]} now has {places[command[1]].Gold} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }


                text = Console.ReadLine();
            }

            if (places.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {places.Count} wealthy settlements to go to:");
                foreach (var item in places.OrderByDescending(n => n.Value.Gold).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
        }
    }
    class Place
    {
        public int Gold { get; set; }
        public int Population { get; set; }
      
    }
   
}
