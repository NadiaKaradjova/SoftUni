using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    public class Opinion_Poll
    {
        public static void Main()
        {
            var family = new List<Person>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var personName = input[0];
                var personAge = int.Parse(input[1]);

                var currentPerson = new Person(personName, personAge);
                family.Add(currentPerson);
            }
            foreach (var person in family.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }            
        }
    }
}
