using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double pStraw = double.Parse(Console.ReadLine());
            double nBanana = double.Parse(Console.ReadLine());
            double nOrang = double.Parse(Console.ReadLine());
            double nRaspb = double.Parse(Console.ReadLine());
            double nStraw = double.Parse(Console.ReadLine());

            double pRaspb = pStraw * 0.5;
            double pOrang = pRaspb - pRaspb * 0.4;
            double pBanana = pRaspb -  pRaspb * 0.8;

            Console.WriteLine($"{(nBanana * pBanana) + (nOrang * pOrang) + (nRaspb * pRaspb) + (nStraw * pStraw)}");
        }
    }
}
