using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Students_by_First_and_Last_Name
{
    public class _02_Students_by_First_and_Last_Name
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


            foreach (var item in students.Where(x => x[0].CompareTo(x[1]) == -1))
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }
        }
    }
}
