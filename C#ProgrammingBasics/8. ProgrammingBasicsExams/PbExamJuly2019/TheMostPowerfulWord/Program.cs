using System;

namespace TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            double count = 0;
            double score = 0;
            double curScore = 0;
            string win = "";


            while (text != "End of words")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    count++;
                    score += (double)Convert.ToChar(text[i]);
                }
                if (text[0] == 'a' || text[0] == 'e' || text[0] == 'i' || text[0] == 'o' || text[0] == 'u' || text[0] == 'y' || text[0] == 'A' || text[0] == 'E' || text[0] == 'I' || text[0] == 'O' || text[0] == 'U' || text[0] == 'Y')
                {
                    score = score * count;
                }
                else
                {
                    score = Math.Floor(score / count);
                }
                if (score > curScore)
                {
                    curScore = score;
                    win = text;
                }



                text = Console.ReadLine();
                count = 0;
                score = 0;
            }
            Console.WriteLine($"The most powerful word is {win} - {curScore}");
        }
    }
}
