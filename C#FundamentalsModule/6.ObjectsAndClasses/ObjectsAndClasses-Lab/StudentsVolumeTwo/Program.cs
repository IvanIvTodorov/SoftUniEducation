using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentsVolumeTwo
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

                if (IsStudentExisting(students, name, lastName))
                {
                    Student student = GetStudent(students, name, lastName);

                    student.Name = name;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student();

                    student.Name = name;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                    students.Add(student);
                }
               
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

        static Student GetStudent(List<Student> students, string name, string LastName)
        {
            Student existing = null;

            foreach (Student item in students)
            {
                if (item.Name == name && item.LastName == LastName)
                {
                    existing = item;
                }
            }

            return existing;
       
        }
        static bool IsStudentExisting(List<Student> students, string name, string lastName)
        {
            foreach (Student item in students)
            {
                if (item.Name == name && item.LastName == lastName)
                {
                    return true;
                }
            }
            return false;

        }
        class Student
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }

        }
    }
}