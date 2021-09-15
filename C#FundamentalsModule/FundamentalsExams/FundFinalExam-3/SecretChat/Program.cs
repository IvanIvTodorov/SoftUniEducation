using System;
using System.Text.RegularExpressions;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string text = Console.ReadLine();

            while (text != "Reveal")
            {
                string[] command = text.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "InsertSpace")
                {
                    input = input.Insert(int.Parse(command[1]), " ");
                    Console.WriteLine(input);
                }
                else if (command[0] == "Reverse")
                {
                    if (input.Contains(command[1]))
                    {
                        char[] rev = command[1].ToCharArray();
                        Array.Reverse(rev);

                        string current = string.Empty;

                        foreach (var item in rev)
                        {
                            current += item;
                        }

                        Regex reg = new Regex(command[1]);
                        input = reg.Replace(input,"", 1);
                        input = input + current;
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "ChangeAll")
                {
                    input = input.Replace(command[1], command[2]);
                    Console.WriteLine(input);
                }

                text = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
