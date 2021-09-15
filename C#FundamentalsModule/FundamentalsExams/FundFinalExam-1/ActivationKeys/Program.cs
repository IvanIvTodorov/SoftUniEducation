using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string text = Console.ReadLine();

            while (text != "Generate")
            {
                string[] command = text
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Contains")
                {
                    if (!input.Contains(command[1]))
                    {
                        Console.WriteLine("Substring not found!");
                    }
                    else
                    {
                        Console.WriteLine($"{input} contains {command[1]}");
                    }
                }
                else if (command[0] == "Flip")
                {
                    string replace = input.Substring(int.Parse(command[2]), (int.Parse(command[3]) - int.Parse(command[2])));

                    if (command[1] == "Upper")
                    {
                       input = input.Replace(replace, replace.ToUpper());
                    }
                    else
                    {
                        input = input .Replace(replace, replace.ToLower());
                    }

                    Console.WriteLine(input);
                }
                else if (command[0] == "Slice")
                {
                    input = input.Remove(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]));
                    Console.WriteLine(input);
                }
                text = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
