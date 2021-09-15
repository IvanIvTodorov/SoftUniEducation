using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                Piece piece = new Piece();

                piece.Composer = input[1];
                piece.Key = input[2];

                pieces.Add(input[0], piece);

            }

            string text = Console.ReadLine();

            while (text != "Stop")
            {
                string[] command = text.Split("|", StringSplitOptions.RemoveEmptyEntries);


                if (command[0] == "Add")
                {
                    if (!pieces.ContainsKey(command[1]))
                    {
                        Piece piece = new Piece();

                        piece.Composer = command[2];
                        piece.Key = command[3];

                        pieces.Add(command[1], piece);
                        Console.WriteLine($"{command[1]} by {command[2]} in {command[3]} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} is already in the collection!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (!pieces.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                    }
                    else
                    {
                        pieces.Remove(command[1]);
                        Console.WriteLine($"Successfully removed {command[1]}!");
                    }
                }
                else if (command[0] == "ChangeKey")
                {
                    if (!pieces.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                    }
                    else
                    {
                        pieces[command[1]].Key = command[2];
                        Console.WriteLine($"Changed the key of {command[1]} to {command[2]}!");
                    }
                }

                text = Console.ReadLine();
            }

            foreach (var item in pieces.OrderBy(n => n.Key).ThenBy(n => n.Value.Composer))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
            }
        }
    }
    class Piece
    {
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
