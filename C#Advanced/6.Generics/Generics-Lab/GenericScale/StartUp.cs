using System;

namespace GenericScale
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            var result = new EqualityScale<int>(5 , 6);

            Console.WriteLine(result.AreEqual());
        }
    }
}
