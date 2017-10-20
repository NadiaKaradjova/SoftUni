using BirthdayCelebrations.Interfaces;
using BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main()
        {
            IList<IBirthable> livingbeings = new List<IBirthable>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var line = input.Split();
                if (line[0] == "Citizen")
                {
                    livingbeings.Add(new Citizens(line[1], int.Parse(line[2]), line[3], line[4]));
                }
                else if (line[0] == "Pet")
                {
                    livingbeings.Add(new Pet(line[1], line[2]));
                }

                input = Console.ReadLine();
            }

            var year = Console.ReadLine();

            foreach (var member in livingbeings.Where(x => x.BirthDate.EndsWith(year)))
            {
                Console.WriteLine(member.BirthDate);
            }
        }
    }
}