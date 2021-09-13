using System;
using System.Text;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);
                }
                else
                {
                    other.Append(text[i]);
                }
            }

            StringBuilder final = new StringBuilder();

            final.AppendLine(digits.ToString());
            final.AppendLine(letters.ToString());
            final.AppendLine(other.ToString());

            Console.WriteLine(final);

        }
    }
}
