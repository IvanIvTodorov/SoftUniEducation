using System;

namespace FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int countMovie = 0;
            int count = 0;
            int countCur = 0;
            int countN = 0;
            int number = 0;
            int curNum = 0;
            string best = "";

            while (movie != "STOP" && countMovie != 7)
            {
                for (int i = 0; i < movie.Length; i++)
                {                    
                        countN++;
                }
                for (int i = 0; i < movie.Length; i++)
                {
                    char current = movie[i];
                    number = (int)Convert.ToChar(current);
                    if (char.IsLower(current))
                    {
                        count += number - countN * 2;
                        countCur += number - countN * 2;
                    }
                    else if (char.IsUpper(current))
                    {
                        count += number - countN;
                        countCur += number - countN;
                    }
                    else
                    {
                        count += number;
                        countCur += number;
                    }
                }

                if (countCur > curNum)
                {
                    curNum = countCur;
                    best = movie;
                }
                countCur = 0;
                countMovie++;
                countN = 0;

                movie = Console.ReadLine();
            }
            if (movie == "STOP")
            {
                Console.WriteLine($"The best movie for you is {best} with {curNum} ASCII sum.");
            }
            else
            {
                Console.WriteLine("The limit is reached.");
                Console.WriteLine($"The best movie for you is {best} with {curNum} ASCII sum.");
            }
        }
    }
}
