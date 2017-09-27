using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Party_Reservation_Filter_Module
{
    public class _11_Party_Reservation_Filter_Module
    {
        public static List<string> guests;

        public static void Main()
        {
            guests = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
             var filters = new List<string>();
            
            var command = Console.ReadLine();
            while (command != "Print")
            {
                var line = command.Split(';');
                var action = line[0];
                var filterType = line[1];
                var filterParam = line[2];
                command = filterType + ";" + filterParam;

                if (action == "Add filter")
                {
                    if (!filters.Contains(command))
                    {
                        filters.Add(command);
                    }
                }
                else
                {
                    filters.Remove(command);
                }                
               
               command = Console.ReadLine();
            }

            foreach (var item in filters)
            {                       
                var line = item.Split(';');
                var filterType = line[0];
                var filterParam = line[1];                
                GetFunc(filterType, filterParam);                
            }

            if (guests.Any())
            {
                Console.WriteLine(string.Join(" ", guests));
            }
        }

        private static void GetFunc(string filterType, string filterParam)
        {
            switch (filterType)
            {
                case "Starts with":
                    {
                       guests = guests.Where(x => !x.StartsWith(filterParam)).ToList();
                       break;
                    };
                case "Ends with":
                    {
                        guests = guests.Where(x => !x.EndsWith(filterParam)).ToList();
                        break;
                    };
                case "Length":
                    {
                        guests = guests.Where(x => x.Length != int.Parse(filterParam)).ToList();
                        break;
                    };
                case "Contains":
                    {
                        guests = guests.Where(x => !x.Contains(filterParam)).ToList();
                        break;
                    };
            }            
        }  
    }
}
