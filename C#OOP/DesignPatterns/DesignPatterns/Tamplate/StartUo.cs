using System;
using Tamplate.Models;

namespace Tamplate
{
    public class StartUo
    {
        static void Main(string[] args)
        {
            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            WhiteBread whiteBread = new WhiteBread();
            whiteBread.Make();
        }
    }
}
