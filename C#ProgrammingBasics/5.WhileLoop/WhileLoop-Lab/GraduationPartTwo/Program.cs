using System;

namespace GraduationPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double grade = 0;
            double number = 1;
            double fail = 0;
            double failTimes = 0;


            while (number != 13)
            {
                double grades = double.Parse(Console.ReadLine());

                if (grades < 4)
                {
                    fail += grades;
                    failTimes += 1;
                    grade += grades;
                    number += 0;
                    if (fail < 7.99 && failTimes > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {number} grade");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    grade += grades;
                    number += 1;
                }
            }
            double average = grade / (number - 1);

            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");

        }
    }
}
