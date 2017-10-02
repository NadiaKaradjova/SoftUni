using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Excellent_Students
{
    public class _07_Excellent_Students
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


            foreach (var item in students.Where(x => x.Contains("6")))
            {
                Console.WriteLine($"{item[0]} {item[1]}");
            }
        }
    }
}
