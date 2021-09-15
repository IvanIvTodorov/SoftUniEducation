using System;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string text = Console.ReadLine();

            while (text != "Done")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "TakeOdd")
                {
                    string current = string.Empty;
                    for (int i = 1; i < input.Length; i += 2)
                    {
                        current += input[i];
                    }
                    input = current;
                    Console.WriteLine(input);
                }
                else if (command[0] == "Cut")
                {
                    input = input.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    
                    Console.WriteLine(input);
                }
                else if (command[0] == "Substitute")
                {
                    if (input.Contains(command[1]))
                    {
                        input = input.Replace(command[1], command[2]);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    
                }
                text = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
