using System;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string text = Console.ReadLine();

            while (text != "Decode")
            {
                string[] command = text.Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Move")
                {
                    string current = input.Substring(0, int.Parse(command[1]));
                    input = input.Remove(0, int.Parse(command[1]));
                    input = input + current;
                }   
                else if (command[0] == "Insert")
                {
                    input = input.Insert(int.Parse(command[1]), command[2]);
                }
                else if (command[0] == "ChangeAll")
                {
                    input = input.Replace(command[1], command[2]);
                }

                text = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
