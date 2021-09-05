using System;

namespace FootballResult
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();
           
            int win = 0;
            int draw = 0;
            int lose = 0;

            char home = result[0];
            char guest = result[2];

            int first = (int)Char.GetNumericValue(home);
            int second = (int)Char.GetNumericValue(guest);
            if (first == second)
            {
                draw++;
            }
            else if (first > second)
            {
                win++;
            }
            else
            {
                lose++;
            }

            string secondR = Console.ReadLine();

            char homeS = secondR[0];
            char guestS = secondR[2];

            int firstS = (int)Char.GetNumericValue(homeS);
            int secondS = (int)Char.GetNumericValue(guestS);

            if (firstS == secondS)
            {
                draw++;
            }
            else if (firstS > secondS)
            {
                win++;
            }
            else
            {
                lose++;
            }

            string thirdR = Console.ReadLine();

            char homeT = thirdR[0];
            char guestT = thirdR[2];

            int firstT = (int)Char.GetNumericValue(homeT);
            int secondT = (int)Char.GetNumericValue(guestT);

            if (firstT == secondT)
            {
                draw++;
            }
            else if (firstT > secondT)
            {
                win++;
            }
            else
            {
                lose++;
            }

            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lose} games.");
            Console.WriteLine($"Drawn games: {draw}");
        }
    }
}
