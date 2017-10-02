using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Students_by_Group
{
    public class _01_Students_by_Group
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


            foreach (var item in students.Where(x => x[2] == "2").OrderBy(x => x[0]))
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }
        }

        
    }
}