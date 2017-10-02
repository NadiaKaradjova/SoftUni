using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Filter_Students_by_Phone
{
    public class _06_Filter_Students_by_Phone
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


            foreach (var item in students.Where(x => x[2].StartsWith("+3592") || x[2].StartsWith("02")))
            {
                Console.WriteLine($"{item[0]} {item[1]}");
            }
        }
    }
}
