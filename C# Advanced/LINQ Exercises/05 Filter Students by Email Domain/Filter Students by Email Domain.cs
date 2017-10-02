using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Filter_Students_by_Email_Domain
{
    public class _05_Filter_Students_by_Email_Domain
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


            foreach (var item in students.Where(x => x[2].EndsWith("@gmail.com")))
            {
                Console.WriteLine($"{item[0]} {item[1]}");
            }
        }
    }
}
