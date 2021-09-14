using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine()
                .Split(", ");

            Dictionary<string, int> peoples = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string namePattern = @"[A-Za-z]+";
                string kmPattern = @"[0-9]";

                MatchCollection letters = Regex.Matches(input, namePattern);
                MatchCollection km = Regex.Matches(input, kmPattern);

                string name = string.Empty;
                foreach (Match item in letters)
                {
                    name += item.Value;
                }
                if (people.Contains(name))
                {
                    int sum = 0;
                    foreach (Match item in km)
                    {
                        sum += int.Parse(item.Value);
                    }
                    if (!peoples.ContainsKey(name))
                    {
                        peoples.Add(name, sum);
                    }
                    else
                    {
                        peoples[name] += sum;
                    }
                    
                }
                input = Console.ReadLine();
            }

            int count = 1;
            foreach (var item in peoples.OrderByDescending(n=> n.Value))
            {
                if (count == 1)
                {
                    Console.WriteLine($"{count++}st place: {item.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"{count++}nd place: {item.Key}");
                }
                else
                {
                    Console.WriteLine($"{count++}rd place: {item.Key}");
                }
                if (count > 3 )
                {
                    break;
                }                
            }

        }
    }
}
