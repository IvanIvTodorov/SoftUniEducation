using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> courses = new Dictionary<string, string>();
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] command = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                
                courses.Add(command[0], command[1]);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] command = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                if (courses.ContainsKey(command[0]) && courses[command[0]] == command[1])
                {

                    if (students.Any(x => x.Name == command[2]) == false)
                    {
                        Student student = new Student();
                        student.Name = command[2];
                        student.Course = new Dictionary<string, int>();
                        student.Course.Add(command[0], int.Parse(command[3]));

                        students.Add(student);
                    }
                    else
                    {
                        int index = students.FindIndex(n => n.Name == command[2]);

                        if (students[index].Course.ContainsKey(command[0]))
                        {
                            if (students[index].Course[command[0]] < int.Parse(command[3]))
                            {
                                students[index].Course[command[0]] = int.Parse(command[3]);
                            }
                            
                        }
                        else
                        {
                            students[index].Course.Add(command[0], int.Parse(command[3]));
                        }
                        
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var item in students.OrderByDescending(x => x.Course.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {item.Name} with total {item.Course.Values.Sum()} points.");
                break;
            }
            Console.WriteLine("Ranking:");

            foreach (var stud in students.OrderBy(n => n.Name))
            {
                Console.WriteLine(stud.Name);
                foreach (var item in stud.Course.OrderByDescending(n => n.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
        class Student
        {
            public string Name { get; set; }
            public Dictionary<string, int> Course { get; set; }
        }
    }
}
