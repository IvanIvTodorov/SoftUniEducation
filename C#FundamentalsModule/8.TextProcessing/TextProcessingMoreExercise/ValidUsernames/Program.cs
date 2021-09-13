using System;
using System.Linq;
using System.Text;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder output = new StringBuilder();

            foreach (string word in text)
            {
                bool isGood = true;
                if (word.Length < 3 || word.Length > 16)
                {
                    isGood = false;
                    continue;
                }
                for (int i = 0; i < word.Length; i++)
                {
                    
                    if (!char.IsLetterOrDigit(word[i]))
                    {
                        if ((char)word[i] != '-' && (char)word[i] != '_')
                        {
                            isGood = false;
                            break;
                        }
                    }
                    
                }
                if (isGood)
                {
                    output.AppendLine($"{word} ");
                }
            }
            Console.WriteLine(output.ToString().Trim());

        }
    }
}
