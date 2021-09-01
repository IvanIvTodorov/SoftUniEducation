using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

         switch (projection)
            {
                case "premiere":
                    Console.WriteLine($"{(r * c) * 12.00m:f2} leva");
                    break;
                case "normal":
                    Console.WriteLine($"{(r * c) * 7.50m:f2} leva");
                    break;
                case "discount":
                    Console.WriteLine($"{(r * c) * 5.00m:f2} leva");
                    break;
            }
        }
    }
}
