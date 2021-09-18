using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < students; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (grades.ContainsKey(command[0]))
                {
                    grades[command[0]].Add(decimal.Parse(command[1]));
                }
                else
                {
                    grades.Add(command[0], new List<decimal>() { decimal.Parse(command[1]) });
                }                    
            }

            foreach (var item in grades)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():F2})");
            }
        }
    }
}
