using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Santa_sSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();
            
            StringBuilder output = new StringBuilder();

            while (text != "end")
            {
                StringBuilder newText = new StringBuilder();
                foreach (char item in text)
                {
                    newText.Append((char)(item - key));
                }

                string pattern = @"@(?<name>[A-Za-z]+)[^\@\-\!\:\>]+\!(?<behaviour>[G|N])\!";
                var matches = Regex.Match(newText.ToString(), pattern);

                if (matches.Groups["behaviour"].Value == "G")
                {
                    output.AppendLine(matches.Groups["name"].Value);
                }

                text = Console.ReadLine();
            }
            Console.WriteLine(output);
        }
    }
}
