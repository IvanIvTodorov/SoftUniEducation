﻿using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            PrintGrade(grade);
        }
        static void PrintGrade(double grade)
        {
            if (grade >= 2.00 && grade < 3.00)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.00 && grade < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
