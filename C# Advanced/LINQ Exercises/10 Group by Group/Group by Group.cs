using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_Group_by_Group
{
    public class _10_Group_by_Group
    {
        public static void Main()
        {
            var students = new List<Student>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var line = input.Split();
                var name = string.Join(" ", line.Take(2));
                var group = int.Parse(line.Last());

                var currentStudent = new Student() { Name = name, Group = group };
                students.Add(currentStudent);

                input = Console.ReadLine();
            }

            var grouped = students.GroupBy(x => x.Group).OrderBy(x => x.Key); 

            foreach (var group in grouped)
            {
                Console.Write(group.Key + " - ");

                var sb = new StringBuilder();
                foreach (var names in group)
                {
                    sb.Append(names.Name).Append(", ");                        
                }
                Console.WriteLine(sb.ToString().TrimEnd(new[] { ',', ' ' }));   
            }
            
        }

        public class Student
        {
            public string Name { get; set; }
            public int Group { get; set; }
        }
    }
}
