using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string text = Console.ReadLine();

            while (text != "Travel")
            {
                string[] command = text.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add Stop")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < input.Length)
                    {
                      input = input.Insert(int.Parse(command[1]), command[2]);
                    }
                }
                else if (command[0] == "Remove Stop")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < input.Length && int.Parse(command[2]) < input.Length)
                    {
                        input = input.Remove(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]) + 1);
                    }
                }
                else if (command[0] == "Switch")
                {
                    if (input.Contains(command[1]))
                    {
                        input = input.Replace(command[1], command[2]);
                    }                   
                }

                Console.WriteLine(input);

                text = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
