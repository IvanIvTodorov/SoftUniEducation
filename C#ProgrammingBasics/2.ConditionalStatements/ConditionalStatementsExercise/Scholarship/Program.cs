using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double wageLv = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            double socialS = minWage * 0.35;
            double gradeS = grade * 25;


            if (wageLv < minWage & grade > 4.5 & grade >= 5.5)
            {
                if (socialS <= gradeS)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeS)} BGN");
                }
                else if (socialS > gradeS)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialS)} BGN");
                }
            }
            else if (wageLv < minWage & grade > 4.5 & grade < 5.50)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialS)} BGN");
            }
            else if (wageLv >= minWage & grade >= 5.50 | wageLv < minWage & grade >=5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeS)} BGN");
            }
            else if (wageLv >= minWage & grade > 4.5 | wageLv < minWage & grade < 4.5 | grade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
          
        }
    }
}
