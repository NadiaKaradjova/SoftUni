using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_Advertisement_Message
{
    public class task7_Advertisement_Message
    {
        public static void Main()
        {
            var phrases = File.ReadAllLines("phrases.txt");
            var events = File.ReadAllLines("events.txt");
            var authors = File.ReadAllLines("authors.txt");
            var cities = File.ReadAllLines("cities.txt");

            var massege = new Random();

            var n = int.Parse(Console.ReadLine());

            var adds = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var phrase = PickRandomElementFromArray(phrases, massege);
                var @event = PickRandomElementFromArray(events, massege);
                var author = PickRandomElementFromArray(authors, massege);
                var city = PickRandomElementFromArray(cities, massege);

                adds.Add($"{phrase} {@event} {author} - {city}");
            }

            File.WriteAllLines("output.txt", adds);
        }
        public static string PickRandomElementFromArray(string[] arr, Random massege)
        {
            var randomValidIndex = massege.Next(0, arr.Length - 1);
            var randomElement = arr[randomValidIndex];
            return randomElement;
        }
    }
}
