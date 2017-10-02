using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Students_by_Age
{
    public class _03_Students_by_Age
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


            foreach (var item in students.Where(x => int.Parse(x[2]) >= 18 && int.Parse(x[2])<=24))
            {
                Console.WriteLine($"{item[0]} {item[1]} {item[2]}");
            }
        }
    }
}
