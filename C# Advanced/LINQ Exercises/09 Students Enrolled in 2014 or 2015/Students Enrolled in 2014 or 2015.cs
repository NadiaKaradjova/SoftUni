using System;
using System.Collections.Generic;
using System.Linq;


namespace _09_Students_Enrolled_in_2014_or_2015
{
    public class _09_Students_Enrolled_in_2014_or_2015
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

            students.Where(a => a[0].EndsWith("14")|| a[0].EndsWith("15"))                
                .Select(a => a.Skip(1)) 
                .ToList()               
                .ForEach(x => Console.WriteLine(string.Join(" ", x)));
        }
    }
}
