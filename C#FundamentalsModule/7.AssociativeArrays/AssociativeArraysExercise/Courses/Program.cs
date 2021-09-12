using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<Course> courses = new List<Course>();
            while (text != "end")
            {
                string[] input = text.Split(" : ");

                if (!courses.Any(n => n.Name == input[0]))
                {

                    Course course = new Course(input[0]);

                    course.NameOfStudents.Add(input[1]);

                    courses.Add(course);
                }
                else
                {
                    int index = courses.FindIndex(n => n.Name == input[0]);
                    courses[index].NameOfStudents.Add(input[1]);
                }

                text = Console.ReadLine();
            }
            foreach (var item in courses.OrderByDescending(n => n.NameOfStudents.Count))
            {
                Console.WriteLine($"{item.Name}: {item.NameOfStudents.Count}");
                foreach (var person in item.NameOfStudents.OrderBy(n  => n))
                {
                    Console.WriteLine($"-- {person}");
                }
            }
        }
    }
    class Course
    {
        public Course(string name)
        {
            Name = name;
            NameOfStudents = new List<string>();
        }
        public string Name { get; set; }
        public List<string> NameOfStudents { get; set; }
    }
}
