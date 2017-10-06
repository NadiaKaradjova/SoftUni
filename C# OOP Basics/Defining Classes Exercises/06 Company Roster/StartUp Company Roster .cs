using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class Company_Roster
    {
        public static void Main()
        {
            var company = new List<Employee>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var personName = input[0];
                var personSalary = double.Parse(input[1]);
                var personPosition = input[2];
                var department = input[3];

                var currentPerson = new Employee(personName, personSalary, personPosition, department);

                if (input.Length > 4)
                {
                    int age;
                    if (int.TryParse(input[4], out age))
                    {
                        currentPerson.Age = age;
                    }
                    else
                    {
                        currentPerson.Email = input[4];
                    }
                }

                if (input.Length > 5)
                {
                    currentPerson.Age = int.Parse(input[5]);
                }

                company.Add(currentPerson);

            }
            var depart = company.GroupBy(dep => dep.Department)
                .Select(gr => new
                {
                    Name = gr.Key,
                    AverageSalary = gr.Average(x => x.Salary),
                    Employees = gr
                })
                .OrderByDescending(gr => gr.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {depart.Name}");
            foreach (var item in depart.Employees.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine(item.PrintEmployeeInfo());
            }               
        }
    }
}
