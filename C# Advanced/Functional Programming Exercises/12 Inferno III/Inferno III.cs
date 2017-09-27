using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Inferno_III
{
    public class _12_Inferno_III
    {
        public static List<int> gems;

        public static void Main()
        {
            gems = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commandLine = Console.ReadLine();
            var commands = new Dictionary<string, Dictionary<int, Predicate<int>>>();

            while (commandLine != "Forge")
            {
                var line = commandLine.Split(';');
                var action = line[0];
                var filterType = line[1];
                var filterParam = int.Parse(line[2]);

                if (action == "Exclude")
                {
                    var filterPred = GetPredicate(filterType, filterParam);
                    if (!commands.ContainsKey(filterType))
                    {
                        commands[filterType] = new Dictionary<int, Predicate<int>>();
                    }
                    commands[filterType].Add(filterParam, filterPred);
                }
                else if (action == "Reverse")
                {
                    commands[filterType].Remove(filterParam);
                }

                commandLine = Console.ReadLine();
            }
            gems = Filter(commands);
            Console.WriteLine(string.Join(" ", gems));
        }

        private static List<int> Filter(Dictionary<string, Dictionary<int, Predicate<int>>> commands)
        {
            var result = new List<int>();
            for (int i = 0; i < gems.Count; i++)
            {
                var isFiltered = false;
                foreach (var command in commands)
                {
                    foreach (var predicate in command.Value)
                    {
                        if (predicate.Value(i))
                        {
                            isFiltered = true;
                            break;
                        }
                    }
                }
                if (!isFiltered)
                {
                    result.Add(gems[i]);
                }
            }
            return result;
        }

        private static Predicate<int> GetPredicate(string filterType, int filterParam)
        {
            switch (filterType)
            {
                case "Sum Left":
                    return i => (i > 0 ? gems[i - 1] : 0) + gems[i] == filterParam;
                    
                case "Sum Right":
                    return i => (i < gems.Count-1 ? gems[i + 1] : 0) + gems[i] == filterParam;
                    
                case "Sum Left Right":
                    return i => (i > 0 ? gems[i - 1] : 0) + gems[i] + (i < gems.Count-1 ? gems[i + 1] : 0) == filterParam;
                    
            }
            return null;
        }
    }
}
