using System;

namespace VolleyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine()); 
            int h = int.Parse(Console.ReadLine()); 

            decimal playNormal = (((48m-h) * 3m / 4m) + h) + (p * 2m / 3m);
            decimal playLeap = playNormal + playNormal * 0.15m;
            

            switch (year)
            {
                case "leap":
                    Console.WriteLine($"{Math.Floor(playLeap)}");
                    break;
                case "normal":
                    Console.WriteLine(Math.Floor(playNormal));
                    break;
            }

        }
    }
}
