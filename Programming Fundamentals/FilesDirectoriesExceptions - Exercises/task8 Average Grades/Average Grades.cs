using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8_Average_Grades
{
    public class task8_Average_Grades
    {
        public static void Main()
        {
            var students = new List<Student>();

            var lines = File.ReadLines("input.txt");

           foreach (var item in lines)
           {
                var line = item.ToString().Split().ToArray();

                var newStudent = new Student();

                newStudent.Name = line[0];
                newStudent.Grades = line.Skip(1).Select(double.Parse).ToList();
                newStudent.AverageGrade = newStudent.Grades.Average();

                students.Add(newStudent);
            }

            File.Delete("output.txt");

            foreach (var item in students.Where(a => a.AverageGrade >= 5.00).OrderBy(x => x.Name).ThenByDescending(g => g.AverageGrade))
            {
                File.AppendAllText("output.txt", $"{item.Name} -> {item.AverageGrade:f2}{Environment.NewLine}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }
    }
}
