using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Weak_Students
{
    public class _08_Weak_Students
    {
        public static void Main()
        {
            var students = new List<string[]>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var line = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                students.Add(line);
                input = Console.ReadLine();
            }

            students.Where(a => a.Skip(2).Count(x => int.Parse(x) <= 3) >= 2)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x[0]} {x[1]}"));

        }
    }
}
