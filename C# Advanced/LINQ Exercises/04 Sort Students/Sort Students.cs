using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Sort_Students
{
    public class _04_Sort_Students
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


            foreach (var item in students.OrderBy(x => x[1]).ThenByDescending(x => x[0]))
            {
                Console.WriteLine($"{item[0]} {item[1]}");
            }
        }
    }
}
