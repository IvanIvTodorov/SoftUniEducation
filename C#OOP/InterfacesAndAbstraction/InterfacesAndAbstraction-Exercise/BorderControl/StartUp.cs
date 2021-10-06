using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<string> inputs = new List<string>();

            while (text != "End")
            {
                inputs.Add(text);

                text = Console.ReadLine();
            }

            string detain = Console.ReadLine();

            foreach (var input in inputs)
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Length > 2)
                {
                    var citizen = new Citizen(command[0], command[1], command[2]);
                    citizen.Detain(detain);
                }
                else
                {
                    var robot = new Robot(command[0], command[1]);
                    robot.Detain(detain);
                }
            }
        }
    }
}
