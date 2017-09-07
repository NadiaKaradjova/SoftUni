using System;
using System.Collections.Generic;
using System.Linq;


namespace task4_Average_Grades
{
    public class task4_Average_Grades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                
                var name = input.First();
                var grades = input.Skip(1).Select(double.Parse).ToArray();

                var currentStudent = new Student() { Name = name, Grades = grades};

                list.Add(currentStudent);              
            }

            list = list.Where(a => a.AverageGrade>=5.00)
                .OrderBy(x => x.Name).ThenByDescending(y => y.AverageGrade).ToList(); 

                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Name} -> {item.AverageGrade:f2}");
                }                   
        }
    }


    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}
