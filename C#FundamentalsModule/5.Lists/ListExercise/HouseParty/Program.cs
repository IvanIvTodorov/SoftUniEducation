using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsNumber = int.Parse(Console.ReadLine());
                
            
            List<string> listOfGuests = new List<string>();
            for (int i = 0; i < commandsNumber; i++)
            {
                string[] command = Console.ReadLine()
                    .Split();
                int count = 0;
                switch (command[2])
                {
                    case "going!":
                        foreach (var guest in listOfGuests)
                        {
                            if (command[0] == guest)
                            {
                                count++;
                                Console.WriteLine($"{command[0]} is already in the list!");
                                break;
                            }
                        }
                        if (count == 0)
                        {
                            listOfGuests.Add(command[0]);                            
                        }
                        break;

                    case "not":
                        foreach (var guest in listOfGuests)
                        {
                            if (command[0] == guest)
                            {
                                count++;
                                listOfGuests.Remove(command[0]);
                                break;
                            }

                        }
                        if (count == 0)
                        {
                            Console.WriteLine($"{command[0]} is not in the list!");
                        }                       
                        break;
                }
            }
            foreach (var guest in listOfGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
