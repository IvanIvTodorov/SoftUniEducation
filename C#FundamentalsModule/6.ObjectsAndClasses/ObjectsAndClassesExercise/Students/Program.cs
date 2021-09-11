using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();

                Student student = new Student(input[0], input[1], decimal.Parse(input[2]));

                students.Add(student);
            }
            foreach (Student item in students.OrderByDescending(n => n.Grade))
            {
                Console.WriteLine(item);
            }
            
        }
    }
    class Student
    {
        public Student(string first,string last, decimal grade)
        {
            FirstName = first;
            LastName = last;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }
    }
}
