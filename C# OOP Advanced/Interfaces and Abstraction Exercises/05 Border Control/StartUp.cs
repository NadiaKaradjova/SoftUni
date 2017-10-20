using BorderControl.Interfaces;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            IList<IIdentifiable> detained = new List<IIdentifiable>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var line = input.Split();
                if (line.Length == 2)
                {
                    detained.Add(new Robot(line[0], line[1]));
                }
                else
                {
                    detained.Add(new Citizens(line[0], int.Parse(line[1]), line[2]));
                }

                input = Console.ReadLine();
            }

            var fakeIdParam = Console.ReadLine();

            foreach (var member in detained.Where(x => x.Id.EndsWith(fakeIdParam)))
            {
                Console.WriteLine(member.Id);
            }
        }
    }
}