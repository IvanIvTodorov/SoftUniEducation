using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] text = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = text[0];
                string lastName = text[1];
                int age = int.Parse(text[2]);
                string homeTown = text[3];

                Student student = new Student();

                student.Name = name;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                students.Add(student);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            List<Student> final = students
                .Where(n => n.HomeTown == input)
                .ToList();

            foreach (Student item in final)
            {
                Console.WriteLine($"{item.Name} {item.LastName} is {item.Age} years old.");
            }

        }
    }
    class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
