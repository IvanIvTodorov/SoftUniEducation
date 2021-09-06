using System;
using System.Numerics;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            BigInteger volume = 0;
            short snow = 0;
            short time = 0;
            short quality = 0;

            for (int i = 1; i <= n; i++)
            {
                short curSnow = short.Parse(Console.ReadLine());
                short curTime = short.Parse(Console.ReadLine());
                byte curQuality = byte.Parse(Console.ReadLine());

                BigInteger curVolume = BigInteger.Pow(curSnow / curTime, curQuality);

                if (curVolume > volume)
                {
                    volume = curVolume;
                    snow = curSnow;
                    time = curTime;
                    quality = curQuality;
                }
            }
            Console.WriteLine($"{snow} : {time} = {volume} ({quality})");
        }
    }
}