using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double yPercent = percent / 100;
            Console.WriteLine(deposit + month * ((deposit * yPercent) / 12));
        }
    }
}
