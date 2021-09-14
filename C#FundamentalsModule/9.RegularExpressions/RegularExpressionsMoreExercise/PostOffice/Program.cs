using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            string starts = @"(\#|\$|\%|\*|\&)(?<name>[A-Z]+)\1";
            string finish = @"[\d]+:[0-1][0-9]+|[2][0]+";

            var match = Regex.Match(input[0].ToString(), starts);
            var length = Regex.Matches(input[1].ToString(), finish);          
                
            StringBuilder output = new StringBuilder();
            int wordLength = 0;
            string start = match.Groups["name"].Value.ToString();
            foreach (char item in start)
            {
                foreach (Match number in length)
                {                  
                    string[] split = number
                        .ToString()
                        .Split(":", StringSplitOptions.RemoveEmptyEntries);

                    int position = int.Parse(split[0]);
                    int howLong = int.Parse(split[1]);
                    
                    if (item == position && howLong != 0)
                    {                        
                        string[] text = input[2]
                        .ToString()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                        wordLength = ++howLong;

                        foreach (var word in text)
                        {
                            if (word[0] == item && word.Length == wordLength)
                            {
                                output.AppendLine(word);
                                break;
                            }
                        }
                        if (output.Length > wordLength)
                        {
                            wordLength += 2;
                            break;
                        }
                    }                    
                }                
            }
            Console.WriteLine(output);
        }
    }
}
