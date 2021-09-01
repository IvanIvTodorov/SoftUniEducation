using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourE = int.Parse(Console.ReadLine());
            int minE = int.Parse(Console.ReadLine());
            int hourA = int.Parse(Console.ReadLine());
            int minA = int.Parse(Console.ReadLine());
            int hourExam = hourE * 60 + minE;
            int hourArrival = hourA * 60 + minA;
            int diference = Math.Abs(hourExam - hourArrival);
            int hours = diference / 60;
            int minutes = diference % 60;

            if (hourExam < hourArrival)
            {
                if (diference < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diference} minutes after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }
            else if (hourExam > hourArrival && diference > 30)
            {
                if (diference <60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diference} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                if (hourExam == hourArrival)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{diference} minutes before the start");
                }
            }




        }
    }
}
