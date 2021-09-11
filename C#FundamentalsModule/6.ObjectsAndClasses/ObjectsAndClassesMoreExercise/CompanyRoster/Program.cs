using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] text = Console.ReadLine()
                    .Split();


                Employee employee = new Employee(text[0], double.Parse(text[1]), text[2]);
                   
                    employees.Add(employee);                   
            }

            double max = double.MinValue;
            string nameMax = string.Empty;
            foreach (Employee item in employees)
            {
                int count = 0;
                double sum = 0;
                string name = item.Department;
                foreach (var items in employees)
                {
                    if (name == items.Department)
                    {
                        sum += items.Salary;
                        count++;
                    }
                }

                double average = sum / count;
                if (average > max)
                {
                    max = average;
                    nameMax = item.Department;
                }
               
            }
            StringBuilder texts = new StringBuilder();
            texts.AppendLine($"Highest Average Salary: {nameMax}");
            foreach (Employee item in employees.Where(n => n.Department == nameMax).OrderByDescending(n => n.Salary))
            {
                
                texts.AppendLine($"{item.Name} {item.Salary:F2}");
            }

            Console.WriteLine(texts.ToString());          
        }
    }
    class Employee
    {
        public Employee( string name, double salary,string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
       
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
