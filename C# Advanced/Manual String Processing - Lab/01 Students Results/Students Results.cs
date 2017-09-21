using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Students_Results
{
    public class _01_Students_Results
    {
        public static void Main()
        {
            var students = new Dictionary<string, double[]>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new [] { " - " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = input[0];
                var grades = input[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                students.Add(name, grades);
            }

            Console.WriteLine(string.Format($"{"Name", -10}|{"CAdv",7}|{"COOP",7}|{"AdvOOP",7}|{"Average",7}|"));
            foreach (var student in students)
            {
                Console.WriteLine(string.Format($"{student.Key,-10}|{student.Value[0],7:f2}|{student.Value[1],7:f2}|{student.Value[2],7:f2}|{student.Value.Average(),7:f4}|"));
            }
        }
    }
}
