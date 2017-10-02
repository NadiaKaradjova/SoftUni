using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Students_Joined_to_Specialties
{
    public class _11_Students_Joined_to_Specialties
    {
        public static void Main()
        {

            var students = new List<Student>();
            var specialities = new List<StudentSpecialty>();

            var input = Console.ReadLine();
            while (input != "Students:")
            {
                var line = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                specialities.Add(new StudentSpecialty(line[0] + " " + line[1], int.Parse(line[2])));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                var line = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                students.Add(new Student(line[1] + " " + line[2], int.Parse(line[0])));

                input = Console.ReadLine();
            }

            specialities.Join(students, sp => sp.FacultyNumber, st => st.FacultyNumber, (sp, st) => new
            {
                Name = st.StudentName,
                FacNumber = sp.FacultyNumber,
                Faculty = sp.SpecialtyName

            })
            .OrderBy(x=> x.Name)
            .ToList()
            .ForEach(x=> Console.WriteLine($"{x.Name} {x.FacNumber} {x.Faculty}"));
        }

        public class StudentSpecialty
        {
            public string SpecialtyName { get; set; }
            public int FacultyNumber { get; set; }

            public StudentSpecialty(string name, int num)
            {
                this.SpecialtyName = name;
                this.FacultyNumber = num;
            }
        }

        public class Student
        {
            public string StudentName { get; set; }
            public int FacultyNumber { get; set; }

            public Student(string name, int num)
            {
                this.StudentName = name;
                this.FacultyNumber = num;
            }
        }
    }
}
