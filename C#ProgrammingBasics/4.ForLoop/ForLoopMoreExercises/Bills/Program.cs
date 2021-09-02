using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            decimal electricity = 0.00m;
            decimal water = 0.00m;
            decimal internet = 0.00m;
            decimal others = 0.00m;
            decimal average = 0.00m;

            for (int i = 1; i <= months; i++)
            {
                decimal electricityP = decimal.Parse(Console.ReadLine());

                electricity += electricityP;
                water += 20;
                internet += 15;
                others += (electricityP + 20 + 15) + 0.20m * (electricityP + 20 + 15);
            }
            average = (electricity + water + internet + others) / months;
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
