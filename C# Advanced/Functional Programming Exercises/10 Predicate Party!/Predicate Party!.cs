using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Predicate_Party_
{
    public class _10_Predicate_Party_
    {
        public static List<string> guests;

        public static void Main()
        {
            guests = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine();

            while (command != "Party!")
            {
                var line = command.Split();
                var action = line[0];
                var filterType = line[1];
                var filterParam = line[2];

                if (action == "Double")
                {
                    var names = Double(filterType, filterParam);
                    foreach (var item in names)
                    {
                        var i = guests.IndexOf(item);
                        guests.Insert(i, item);
                    }
                }
                else if (action == "Remove")
                {
                    var names = Double(filterType, filterParam);
                    foreach (var item in names)
                    {
                        var i = guests.IndexOf(item);
                        guests.RemoveAt(i);
                    }
                }
                command = Console.ReadLine();
            }
            if (guests.Count > 0)
            {
                Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            
            }
        private static List<string> Double(string filterType, string filterParam)
        {
            var names = new List<string>();
            switch (filterType)
            {
                case "StartsWith":                  
                        names = guests.Where(x => x.StartsWith(filterParam)).ToList();                       
                        break;
                case "EndsWith":                   
                        names = guests.Where(x => x.EndsWith(filterParam)).ToList();                        
                        break; 
                case "Length":
                        names = guests.Where(x => x.Length == int.Parse(filterParam)).ToList();                      
                        break; 
            }

            return names;
        }
    }
}
