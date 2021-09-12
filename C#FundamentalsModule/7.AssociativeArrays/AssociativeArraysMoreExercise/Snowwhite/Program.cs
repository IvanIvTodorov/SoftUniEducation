using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();
            while (input != "Once upon a time")
            {
                string[] text = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

                if (!dwarfs.Any(n => n.Key.Contains(text[1])))
                {
                    dwarfs.Add(text[1], new Dictionary<string, int>());

                    dwarfs[text[1]].Add(text[0], int.Parse(text[2]));
                    
                }
                else
                {

                    if (dwarfs.Any(n => n.Key.Contains(text[1])) && dwarfs[text[1]].ContainsKey(text[0]))
                    {
                        if (dwarfs[text[1]][text[0]] < int.Parse(text[2]))
                        {
                            dwarfs[text[1]][text[0]] = int.Parse(text[2]);
                        }
                    }
                    else
                    {
                        dwarfs[text[1]].Add(text[0], int.Parse(text[2]));
                    }
                   
                }
                
                input = Console.ReadLine();
            }

            StringBuilder output = new StringBuilder();

            Dictionary<string, int> final = new Dictionary<string, int>();

            foreach (var item in dwarfs.OrderByDescending(n => n.Value.Count()))
            {
                
                foreach (var name in item.Value)
                {
                    final.Add($"({item.Key}) {name.Key} <-> ", name.Value);
                }
                                          
            }
            foreach (var item in final.OrderByDescending(n => n.Value))
            {
                output.AppendLine($"{item.Key}{item.Value}");
            }

            Console.WriteLine(string.Join(Environment.NewLine, output));
        }
    }
 
}
