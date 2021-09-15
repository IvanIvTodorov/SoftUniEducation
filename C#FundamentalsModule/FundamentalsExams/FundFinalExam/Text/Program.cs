using System;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string text = Console.ReadLine();

            while (text != "Finish")
            {

                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Replace")
                {
                    input = input.Replace(command[1], command[2]);
                    Console.WriteLine(input);
                }
                else if (command[0] == "Cut")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < input.Length && int.Parse(command[2]) < input.Length)
                    {
                        input = input.Remove(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]) + 1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                else if (command[0] == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        input = input.ToUpper();
                    }
                    else
                    {
                        input = input.ToLower();
                    }
                    Console.WriteLine(input);
                }
                else if (command[0] == "Check")
                {
                    if (input.Contains(command[1]))
                    {
                        Console.WriteLine($"Message contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {command[1]}");
                    }
                }
                else if (command[0] == "Sum")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < input.Length && int.Parse(command[2]) < input.Length)
                    {
                        string current = input.Substring(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]) + 1);

                        char[] arr = current.ToCharArray();
                        int sum = 0;
                        foreach (var item in arr)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }

                text = Console.ReadLine();
            }
        }
    }
}
